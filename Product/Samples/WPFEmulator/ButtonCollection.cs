////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Microsoft.SPOT.Emulator.Sample
{
    /// <summary>
    /// Defines a control that can receive focus and route keyboard events to 
    /// child Button controls.
    /// </summary>
    public class ButtonCollection : ContainerControl
    {
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ButtonCollection()
        {
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        /// <summary>
        /// Simple design mode to allow this control to be used with the WinForm 
        /// designer.
        /// </summary>
        private void OnPaintDesignMode(PaintEventArgs e)
        {
            Rectangle rc = this.ClientRectangle;
            Color penColor;

            // Select a black or white pen, depending on the color of the 
            // control.
            if (this.BackColor.GetBrightness() < .5)
            {
                penColor = ControlPaint.Light(this.BackColor);
            }
            else
            {
                penColor = ControlPaint.Dark(this.BackColor); ;
            }

            using (Pen pen = new Pen(penColor))
            {
                pen.DashStyle = DashStyle.Dash;

                rc.Width--;
                rc.Height--;
                e.Graphics.DrawRectangle(pen, rc);
            }
        }

        /// <summary>
        /// Handles a paint event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                // At design time, paint a dotted outline around the control.
                this.OnPaintBackground(e);
                OnPaintDesignMode(e);
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// Find any child Button controls that want to receive this key as 
        /// data.
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        private Button GetButtonForInputKey(Keys keyData)
        {
            for (int iChild = 0; iChild < this.Controls.Count; iChild++)
            {
                Button button = this.Controls[iChild] as Button;

                if (button != null)
                {
                    if (button.Key == keyData)
                    {
                        return button;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool IsInputKey(Keys keyData)
        {
            return GetButtonForInputKey(keyData) != null;
        }

        /// <summary>
        /// Handles a key-down event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Button button = GetButtonForInputKey(e.KeyData);

            if (button != null)
            {
                button.OnButtonStateChanged(true);
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        /// <summary>
        /// Handles a key-up event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            Button button = GetButtonForInputKey(e.KeyData);

            if (button != null)
            {
                button.OnButtonStateChanged(false);
            }
            else
            {
                base.OnKeyUp(e);
            }
        }
    }
}

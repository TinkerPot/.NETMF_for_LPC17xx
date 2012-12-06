/***********************************************************************/
/*                                                                     */
/*  FILE        :vecttbl.c                                             */
/*  DATE        :Wed, Apr 22, 2009                                     */
/*  DESCRIPTION :Initialize of Vector Table                            */
/*  CPU TYPE    :SH7619                                                */
/*                                                                     */
/*  This file is generated by Renesas Project Generator (Ver.4.9).     */
/*                                                                     */
/***********************************************************************/
                  


#include "vect.h"

#pragma section VECTTBL

void *RESET_Vectors[] = {
//;<<VECTOR DATA START (POWER ON RESET)>>
//;0 Power On Reset PC
    (void*)	PowerON_Reset_PC,                                                                                                                
//;<<VECTOR DATA END (POWER ON RESET)>>
// 1 Power On Reset SP
    __secend("S")

};

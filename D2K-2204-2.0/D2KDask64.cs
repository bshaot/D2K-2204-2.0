using System.Runtime.InteropServices;
using System;

public delegate void CallbackDelegate();  

public class D2KDASK
{
	//DAQ2000 Device
	public const ushort DAQ_2010        =1;
	public const ushort DAQ_2205        =2;
	public const ushort DAQ_2206        =3;
	public const ushort DAQ_2005        =4;
	public const ushort DAQ_2204        =5;
	public const ushort DAQ_2006        =6;
	public const ushort DAQ_2501        =7;
	public const ushort DAQ_2502        =8;
	public const ushort DAQ_2208        =9;
	public const ushort DAQ_2213        =10;
	public const ushort DAQ_2214        =11;
	public const ushort DAQ_2016        =12;
	public const ushort DAQ_2020        =13;
	public const ushort DAQ_2022        =14;	

	public const ushort MAX_CARD        =32;

	//Error Number
	public const short NoError                       =0;
	public const short ErrorUnknownCardType         =-1;
	public const short ErrorInvalidCardNumber       =-2;
	public const short ErrorTooManyCardRegistered   =-3;
	public const short ErrorCardNotRegistered       =-4;
	public const short ErrorFuncNotSupport          =-5;
	public const short ErrorInvalidIoChannel        =-6;
	public const short ErrorInvalidAdRange          =-7;
	public const short ErrorContIoNotAllowed        =-8;
	public const short ErrorDiffRangeNotSupport     =-9;
	public const short ErrorLastChannelNotZero      =-10;
	public const short ErrorChannelNotDescending    =-11;
	public const short ErrorChannelNotAscending     =-12;
	public const short ErrorOpenDriverFailed        =-13;
	public const short ErrorOpenEventFailed         =-14;
	public const short ErrorTransferCountTooLarge   =-15;
	public const short ErrorNotDoubleBufferMode     =-16;
	public const short ErrorInvalidSampleRate       =-17;
	public const short ErrorInvalidCounterMode      =-18;
	public const short ErrorInvalidCounter          =-19;
	public const short ErrorInvalidCounterState     =-20;
	public const short ErrorInvalidBinBcdParam      =-21;
	public const short ErrorBadCardType             =-22;
	public const short ErrorInvalidDaRefVoltage     =-23;
	public const short ErrorAdTimeOut               =-24;
	public const short ErrorNoAsyncAI               =-25;
	public const short ErrorNoAsyncAO               =-26;
	public const short ErrorNoAsyncDI               =-27;
	public const short ErrorNoAsyncDO               =-28;
	public const short ErrorNotInputPort            =-29;
	public const short ErrorNotOutputPort           =-30;
	public const short ErrorInvalidDioPort          =-31;
	public const short ErrorInvalidDioLine          =-32;
	public const short ErrorContIoActive            =-33;
	public const short ErrorDblBufModeNotAllowed    =-34;
	public const short ErrorConfigFailed            =-35;
	public const short ErrorInvalidPortDirection    =-36;
	public const short ErrorBeginThreadError        =-37;
	public const short ErrorInvalidPortWidth        =-38;
	public const short ErrorInvalidCtrSource        =-39;
	public const short ErrorOpenFile                =-40;
	public const short ErrorAllocateMemory          =-41;
	public const short ErrorDaVoltageOutOfRange     =-42;
	public const short ErrorInvalidSyncMode         =-43;
	public const short ErrorInvalidBufferID         =-44;
	public const short ErrorInvalidCNTInterval	=-45;
	public const short ErrorReTrigModeNotAllowed    =-46;
	public const short ErrorResetBufferNotAllowed   =-47;
	public const short ErrorAnaTriggerLevel         =-48;
	public const short ErrorDAQEvent	        =-49;
	public const short ErrorInvalidCounterValue = -50; 
	public const short ErrorOffsetCalibration   = -51;
	public const short ErrorGainCalibration     =  -52;
	public const short ErrorCountOutofSDRAMSize =  -53;
	public const short ErrorNotStartTriggerModule = -54;
	public const short ErrorInvalidRouteLine      = -55;
	public const short ErrorInvalidSignalCode     = -56;
	public const short ErrorInvalidSignalDirection = -57;
	public const short ErrorTRGOSCalibration      = -58;
	public const short ErrorNoSDRAM               = -59;
	public const short ErrorIntegrationGain       = -60;
	public const short ErrorAcquisitionTiming     = -61;
	public const short ErrorIntegrationTiming     = -62;
	public const short ErrorInvalidTimeBase       = -70;
	public const short ErrorUndefinedParameter    = -71;
	//Error number for calibration API
	public const short ErrorCalAddress      = -110;
	public const short ErrorInvalidCalBank	= -111;
	//Error number for driver API 
	public const short ErrorConfigIoctl			 =-201;
	public const short ErrorAsyncSetIoctl			 =-202;
	public const short ErrorDBSetIoctl				 =-203;
	public const short ErrorDBHalfReadyIoctl		 =-204;
	public const short ErrorContOPIoctl			 =-205;
	public const short ErrorContStatusIoctl		 =-206;
	public const short ErrorPIOIoctl				 =-207;
	public const short ErrorDIntSetIoctl			 =-208;
	public const short ErrorWaitEvtIoctl			 =-209;
	public const short ErrorOpenEvtIoctl			 =-210;
	public const short ErrorCOSIntSetIoctl			 =-211;
	public const short ErrorMemMapIoctl			 =-212;
	public const short ErrorMemUMapSetIoctl		 =-213;
	public const short ErrorCTRIoctl			     =-214;
	public const short ErrorGetResIoctl		     =-215;

	//Synchronous Mode
	public const ushort SYNCH_OP        =1;
	public const ushort ASYNCH_OP       =2;

	//AD Range
	public const ushort AD_B_10_V       =1;
	public const ushort AD_B_5_V        =2;
	public const ushort AD_B_2_5_V      =3;
	public const ushort AD_B_1_25_V     =4;
	public const ushort AD_B_0_625_V    =5;
	public const ushort AD_B_0_3125_V   =6;
	public const ushort AD_B_0_5_V      =7;
	public const ushort AD_B_0_05_V     =8;
	public const ushort AD_B_0_005_V    =9;
	public const ushort AD_B_1_V       =10;
	public const ushort AD_B_0_1_V     =11;
	public const ushort AD_B_0_01_V    =12;
	public const ushort AD_B_0_001_V   =13;
	public const ushort AD_U_20_V      =14;
	public const ushort AD_U_10_V      =15;
	public const ushort AD_U_5_V       =16;
	public const ushort AD_U_2_5_V     =17;
	public const ushort AD_U_1_25_V    =18;
	public const ushort AD_U_1_V       =19;
	public const ushort AD_U_0_1_V     =20;
	public const ushort AD_U_0_01_V    =21;
	public const ushort AD_U_0_001_V   =22;
	public const ushort AD_B_2_V	   =23;
	public const ushort AD_B_0_25_V    =24;
	public const ushort AD_B_0_2_V     =25;
	public const ushort AD_U_4_V	   =26;
	public const ushort AD_U_2_V	   =27;
	public const ushort AD_U_0_5_V     =28;
	public const ushort AD_U_0_4_V     =29;

	//DIO Port Direction
	public const ushort INPUT_PORT      =1;
	public const ushort OUTPUT_PORT     =2;

	//Channel & Port
	public const ushort Channel_P1A             =0;
	public const ushort Channel_P1B             =1;
	public const ushort Channel_P1C             =2;
	public const ushort Channel_P1CL            =3;
	public const ushort Channel_P1CH            =4;
	public const ushort Channel_P1AE            =10;
	public const ushort Channel_P1BE            =11;
	public const ushort Channel_P1CE            =12;
	public const ushort Channel_P2A             =5;
	public const ushort Channel_P2B             =6;
	public const ushort Channel_P2C             =7;
	public const ushort Channel_P2CL            =8;
	public const ushort Channel_P2CH            =9;
	public const ushort Channel_P2AE            =15;
	public const ushort Channel_P2BE            =16;
	public const ushort Channel_P2CE            =17;
	public const ushort Channel_P3A             =10;
	public const ushort Channel_P3B             =11;
	public const ushort Channel_P3C             =12;
	public const ushort Channel_P3CL            =13;
	public const ushort Channel_P3CH            =14;
	public const ushort Channel_P4A             =15;
	public const ushort Channel_P4B             =16;
	public const ushort Channel_P4C             =17;
	public const ushort Channel_P4CL            =18;
	public const ushort Channel_P4CH            =19;
	public const ushort Channel_P5A             =20;
	public const ushort Channel_P5B             =21;
	public const ushort Channel_P5C             =22;
	public const ushort Channel_P5CL            =23;
	public const ushort Channel_P5CH            =24;
	public const ushort Channel_P6A             =25;
	public const ushort Channel_P6B             =26;
	public const ushort Channel_P6C             =27;
	public const ushort Channel_P6CL            =28;
	public const ushort Channel_P6CH            =29;

	/*-------- Constants for DAQ2000 --------------------*/

	public const short All_Channels	=-1;
	public const short BufferNotUsed	=-1;
	/* Constants for Analog trigger */
	/* define analog trigger condition constants */
	public const ushort Below_Low_level         =0x0000;
	public const ushort Above_High_Level        =0x0100;
	public const ushort Inside_Region           =0x0200;
	public const ushort High_Hysteresis         =0x0300;
	public const ushort Low_Hysteresis          =0x0400;
	/* define analog trigger Dedicated Channel */
	public const ushort CH0ATRIG				=0x00;
	public const ushort CH1ATRIG				=0x02;
	public const ushort CH2ATRIG				=0x04;
	public const ushort CH3ATRIG				=0x06;
	public const ushort EXTATRIG				=0x01;
	public const ushort ADCATRIG				=0x00; //used for DAQ-2205/2206
	/* Time Base */
	public const ushort DAQ2K_IntTimeBase		=0x00;
	public const ushort DAQ2K_ExtTimeBase		=0x01;
	public const ushort DAQ2K_SSITimeBase		=0x02;
	public const ushort DAQ2K_ExtTimeBase_AFI0	=0x03;
	public const ushort DAQ2K_ExtTimeBase_AFI1	=0x04;
	public const ushort DAQ2K_ExtTimeBase_AFI2	=0x05;
	public const ushort DAQ2K_ExtTimeBase_AFI3	=0x06;
	public const ushort DAQ2K_ExtTimeBase_AFI4	=0x07;
	public const ushort DAQ2K_ExtTimeBase_AFI5	=0x08;
	public const ushort DAQ2K_ExtTimeBase_AFI6	=0x09;
	public const ushort DAQ2K_ExtTimeBase_AFI7	=0xa;
	public const ushort DAQ2K_PXI_CLK		=0xc;
	public const ushort DAQ2K_StarTimeBase		=0xd;
	public const ushort DAQ2K_SMBTimeBase		=0xe;
	
	/* Constants for AD	*/
	public const ushort DAQ2K_AI_ADSTARTSRC_Int    =0x00;
	public const ushort DAQ2K_AI_ADSTARTSRC_AFI0   =0x10;
	public const ushort DAQ2K_AI_ADSTARTSRC_SSI    =0x20;

	public const ushort DAQ2K_AI_ADCONVSRC_Int    =0x00;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI0   =0x04;
	public const ushort DAQ2K_AI_ADCONVSRC_SSI    =0x08;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI1   =0x0C;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI2   =0x100;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI3   =0x200;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI4   =0x300;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI5   =0x400;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI6   =0x500;
	public const ushort DAQ2K_AI_ADCONVSRC_AFI7   =0x600;

	public const ushort DAQ2K_AI_ADCONVSRC_PFI0   =DAQ2K_AI_ADCONVSRC_AFI0;

	//AI Delay Counter SRC: only available for DAQ-250X
	public const ushort DAQ2K_AI_DTSRC_Int      =0x00;
	public const ushort DAQ2K_AI_DTSRC_AFI1     =0x10;
	public const ushort DAQ2K_AI_DTSRC_GPTC0    =0x20;
	public const ushort DAQ2K_AI_DTSRC_GPTC1    =0x30;

	public const ushort DAQ2K_AI_TRGSRC_SOFT      =0x00;   
	public const ushort DAQ2K_AI_TRGSRC_ANA       =0x01;   
	public const ushort DAQ2K_AI_TRGSRC_ExtD      =0x02;   
	public const ushort DAQ2K_AI_TRSRC_SSI        =0x03;   
	public const ushort DAQ2K_AI_TRGMOD_POST      =0x00;   //Post Trigger Mode
	public const ushort DAQ2K_AI_TRGMOD_DELAY     =0x08;   //Delay Trigger Mode
	public const ushort DAQ2K_AI_TRGMOD_PRE       =0x10;   //Pre-Trigger Mode
	public const ushort DAQ2K_AI_TRGMOD_MIDL      =0x18;   //Middle Trigger Mode
	public const ushort DAQ2K_AI_ReTrigEn         =0x80;
	public const ushort DAQ2K_AI_Dly1InSamples    =0x100;
	public const ushort DAQ2K_AI_Dly1InTimebase   =0x000;
	public const ushort DAQ2K_AI_MCounterEn       =0x400;
	public const ushort DAQ2K_AI_TrgPositive      =0x0000;
	public const ushort DAQ2K_AI_TrgNegative      =0x1000;
	
	public const uint DAQ2K_AI_TRGSRC_AFI0 = 0x10000;
	public const uint DAQ2K_AI_TRGSRC_AFI1 = 0x20000;
	public const uint DAQ2K_AI_TRGSRC_AFI2 = 0x30000;
	public const uint DAQ2K_AI_TRGSRC_AFI3 = 0x40000;
	public const uint DAQ2K_AI_TRGSRC_AFI4 = 0x50000;
	public const uint DAQ2K_AI_TRGSRC_AFI5 = 0x60000;
	public const uint DAQ2K_AI_TRGSRC_AFI6 = 0x70000;
	public const uint DAQ2K_AI_TRGSRC_AFI7 = 0x80000;
	public const uint DAQ2K_AI_TRGSRC_PXIStar = 0xa0000;
	public const uint DAQ2K_AI_TRGSRC_SMB = 0xb0000;
	
	//AI Reference ground
	public const ushort	AI_RSE			=0x0000;
	public const ushort	AI_DIFF			=0x0100;
	public const ushort	AI_NRSE			=0x0200;
	/* Constants for DA	*/
	//DA CH config constant
	public const ushort DAQ2K_DA_BiPolar          =0x1;
	public const ushort DAQ2K_DA_UniPolar         =0x0;
	public const ushort DAQ2K_DA_Int_REF          =0x0;
	public const ushort DAQ2K_DA_Ext_REF          =0x1;
	//DA control constant
	public const ushort DAQ2K_DA_WRSRC_Int      =0x00;
	public const ushort DAQ2K_DA_WRSRC_AFI1     =0x01;
	public const ushort DAQ2K_DA_WRSRC_SSI      =0x02;

	public const ushort DAQ2K_DA_WRSRC_PFI0     =DAQ2K_DA_WRSRC_AFI0;
	public const ushort DAQ2K_DA_WRSRC_AFI0     =DAQ2K_DA_WRSRC_AFI1;
	//DA group 
	public const ushort	DA_Group_A		=0x00;
	public const ushort	DA_Group_B		=0x04;
	public const ushort	DA_Group_AB		=0x08;
	//DA TD Counter SRC: only available for DAQ-250X
	public const ushort DAQ2K_DA_TDSRC_Int      =0x00;
	public const ushort DAQ2K_DA_TDSRC_AFI0     =0x10;
	public const ushort DAQ2K_DA_TDSRC_GPTC0    =0x20;
	public const ushort DAQ2K_DA_TDSRC_GPTC1    =0x30;
	//DA BD Counter SRC: only available for DAQ-250X
	public const ushort DAQ2K_DA_BDSRC_Int      =0x00;
	public const ushort DAQ2K_DA_BDSRC_AFI0     =0x40;
	public const ushort DAQ2K_DA_BDSRC_GPTC0    =0x80;
	public const ushort DAQ2K_DA_BDSRC_GPTC1    =0xC0;

	//DA trigger constant
	public const ushort DAQ2K_DA_TRGSRC_SOFT    =0x00;   
	public const ushort DAQ2K_DA_TRGSRC_ANA     =0x01;   
	public const ushort DAQ2K_DA_TRGSRC_ExtD    =0x02;  
	public const ushort DAQ2K_DA_TRSRC_SSI      =0x03;
	public const ushort DAQ2K_DA_TRGMOD_POST    =0x00;
	public const ushort DAQ2K_DA_TRGMOD_DELAY   =0x04;
	public const ushort DAQ2K_DA_ReTrigEn       =0x20;
	public const ushort DAQ2K_DA_Dly1InUI		=0x40;
	public const ushort DAQ2K_DA_Dly1InTimebase =0x00;
	public const ushort DAQ2K_DA_Dly2InUI		=0x80;
	public const ushort DAQ2K_DA_Dly2InTimebase =0x00;
	public const ushort DAQ2K_DA_DLY2En			=0x100;
	public const ushort DAQ2K_DA_TrgPositive    =0x000;
	public const ushort DAQ2K_DA_TrgNegative    =0x200;

	//DA stop mode
	public const ushort DAQ2K_DA_TerminateImmediate =0;
	public const ushort DAQ2K_DA_TerminateUC        =1;
	public const ushort DAQ2K_DA_TerminateIC		=2;

	public const ushort DAQ2K_DA_TerminateFIFORC    =DAQ2K_DA_TerminateIC;
	//DA stop source : only available for DAQ-250X
	public const ushort DAQ2K_DA_STOPSRC_SOFT     =0;
	public const ushort DAQ2K_DA_STOPSRC_AFI0     =1;
	public const ushort DAQ2K_DA_STOPSRC_ATrig    =2;
	public const ushort DAQ2K_DA_STOPSRC_AFI1     =3;

	/*-------- Timer/Counter -----------------------------*/
	//Counter Mode (8254)
	public const ushort TOGGLE_OUTPUT             =0;     //Toggle output from low to high on terminal count
	public const ushort PROG_ONE_SHOT             =1;     //Programmable one-shot
	public const ushort RATE_GENERATOR            =2;     //Rate generator
	public const ushort SQ_WAVE_RATE_GENERATOR    =3;     //Square wave rate generator
	public const ushort SOFT_TRIG                 =4;     //Software-triggered strobe
	public const ushort HARD_TRIG                 =5;     //Hardware-triggered strobe
	//16-bit binary or 4-decade BCD counter
	public const ushort BIN             =0;
	public const ushort BCD             =1;
	//General Purpose Timer/Counter
	//Counter Mode
	public const ushort SimpleGatedEventCNT		  =0x01; 
	public const ushort SinglePeriodMSR			  =0x02;
	public const ushort SinglePulseWidthMSR		  =0x03;
	public const ushort SingleGatedPulseGen		  =0x04;
	public const ushort SingleTrigPulseGen	      =0x05;
	public const ushort RetrigSinglePulseGen	  =0x06;
	public const ushort SingleTrigContPulseGen	  =0x07;
	public const ushort ContGatedPulseGen		  =0x08;
	//GPTC clock source
	public const ushort GPTC_GATESRC_EXT		  =0x04;
	public const ushort GPTC_GATESRC_INT		  =0x00;
	public const ushort GPTC_CLKSRC_EXT		      =0x08;
	public const ushort GPTC_CLKSRC_INT		      =0x00;
	public const ushort GPTC_UPDOWN_SEL_EXT	      =0x10;
	public const ushort GPTC_UPDOWN_SEL_INT	      =0x00;
	//GPTC clock polarity
	public const ushort GPTC_CLKEN_LACTIVE        =0x01;
	public const ushort GPTC_CLKEN_HACTIVE		  =0x00;
	public const ushort GPTC_GATE_LACTIVE		  =0x02;
	public const ushort GPTC_GATE_HACTIVE		  =0x00;
	public const ushort GPTC_UPDOWN_LACTIVE	      =0x04;
	public const ushort GPTC_UPDOWN_HACTIVE	      =0x00;
	public const ushort GPTC_OUTPUT_LACTIVE       =0x08;
	public const ushort GPTC_OUTPUT_HACTIVE	      =0x00;
	public const ushort GPTC_INT_LACTIVE	      =0x10;
	public const ushort GPTC_INT_HACTIVE	      =0x00;
	//GPTC paramID
	public const ushort GPTC_IntGATE			  =0x00;
	public const ushort GPTC_IntUpDnCTR			  =0x01;
	public const ushort GPTC_IntENABLE		      =0x02;
	//SSI signal code
	public const ushort SSI_TIME	=1;
	public const ushort SSI_CONV	=2;
	public const ushort SSI_WR		=4;
	public const ushort SSI_ADSTART	=8;
	public const ushort SSI_ADTRIG  =0x20;
	public const ushort SSI_DATRIG  =0x40;
	
	//signal code for GPTC
	public const ushort GPTC_CLK_0 = 0x100; 
	public const ushort GPTC_GATE_0 = 0x200; 
	public const ushort GPTC_OUT_0  = 0x300;
	public const ushort GPTC_CLK_1  = 0x400; 
	public const ushort GPTC_GATE_1  = 0x500; 
	public const ushort GPTC_OUT_1  = 0x600; 
	//signal code for clockoutToSMB source
	public const ushort PXI_CLK_10_M  = 0x1000;
	public const ushort CLK_20_M	   = 0x2000; 
	public const ushort SMB_CLK_IN = 0x3000;

	//signal route lines
	public const ushort PXI_TRIG_0 = 0;
	public const ushort PXI_TRIG_1 = 1;
	public const ushort PXI_TRIG_2 = 2;
	public const ushort PXI_TRIG_3 = 3;
	public const ushort PXI_TRIG_4 = 4;
	public const ushort PXI_TRIG_5 = 5;
	public const ushort PXI_TRIG_6 = 6;
	public const ushort PXI_TRIG_7 = 7;
	public const ushort PXI_STAR_TRIG = 8;
	public const ushort TRG_IO = 9;
	public const ushort SMB_CLK_OUT = 10;
	public const ushort AFI0 = 0x10;
	public const ushort AFI1 = 0x11;
	public const ushort AFI2 = 0x12;
	public const ushort AFI3 = 0x13;
	public const ushort AFI4 = 0x14;
	public const ushort AFI5 = 0x15;
	public const ushort AFI6 = 0x16;
	public const ushort AFI7 = 0x17;
	public const ushort PXI_CLK = 0x18;

	//export signal plarity
	public const ushort Signal_ActiveHigh = 0x0;
	public const ushort Signal_ActiveLow  = 0x1;
	
	//DAQ Event type for the event message  
	public const ushort DAQEnd   =0;
	public const ushort DBEvent  =1;
	public const ushort TrigEvent  =2;
	public const ushort DAQEnd_A   =0;
	public const ushort DAQEnd_B   =2;
	public const ushort DAQEnd_AB  =3;
	public const ushort DATrigEvent    =4;
	public const ushort DATrigEvent_A  =4;
	public const ushort DATrigEvent_B  =5;
	public const ushort DATrigEvent_AB =6;

	/*------------------------------------------------------------------
	** PCIS-DASK Function prototype
	------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Register_Card (ushort CardType, ushort card_num);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Release_Card  (ushort CardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AIO_Config (ushort wCardNumber, ushort TimerBase, ushort AnaTrigCtrl, ushort H_TrgLevel, ushort L_TrgLevel);
	[DllImport("D2K-Dask64.dll")]	
	public static extern short D2K_Register_Card_By_PXISlot_GA (ushort CardType, ushort ga);
	[DllImport("D2K-Dask64.dll")]	
	public static extern short D2K_GetPXISlotGeographAddr (ushort wCardNumber, out bool geo_addr);
	[DllImport("D2K-Dask64.dll")]	
	public static extern short D2K_SoftTrigGen(ushort wCardNumber, byte op);	
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_Config (ushort wCardNumber, ushort ConfigCtrl, uint TrigCtrl, uint MidOrDlyScans, ushort MCnt, ushort ReTrgCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ConfigEx (ushort wCardNumber, ushort ConfigCtrl, uint TrigCtrl, uint MidOrDlyScans, uint MCnt, uint ReTrgCnt, bool AutoResetBuf);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_PostTrig_Config (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, ushort ReTrgEn, ushort ReTrgCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_PostTrig_ConfigEx (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, ushort ReTrgEn, uint ReTrgCnt, bool AutoResetBuf);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_DelayTrig_Config (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, uint DlyScans, ushort ReTrgEn, ushort ReTrgCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_DelayTrig_ConfigEx (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, uint DlyScans, ushort ReTrgEn, uint ReTrgCnt, bool AutoResetBuf);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_PreTrig_Config (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, ushort MCtrEn, ushort MCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_PreTrig_ConfigEx (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, ushort MCtrEn, uint MCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_MiddleTrig_Config (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, uint MiddleScans, ushort MCtrEn, ushort MCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_MiddleTrig_ConfigEx (ushort wCardNumber, ushort ClkSrc, uint TrigSrcCtrl, uint MiddleScans, ushort MCtrEn, uint MCnt, bool AutoResetBuf);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_CH_Config (ushort wCardNumber, short wChannel, ushort wAdRange_RefGnd);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_InitialMemoryAllocated (ushort CardNumber, out uint MemSize);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ReadChannel (ushort CardNumber, ushort Channel, out ushort Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_VReadChannel (ushort CardNumber, ushort Channel, out double voltage);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_SimuReadChannel (ushort wCardNumber, ushort wNumChans, ushort[] pwChans, ushort[] pwBuffer);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ScanReadChannels (ushort wCardNumber, ushort wNumChans, ushort[] pwChans, ushort[] pwBuffer);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_VoltScale (ushort CardNumber, ushort AdRange, short reading, out double voltage);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContReadChannel (ushort CardNumber, ushort Channel,
					  ushort BufId, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContReadMultiChannels (ushort CardNumber, ushort NumChans, ushort[] Chans,
					  ushort BufId, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContScanChannels (ushort CardNumber, ushort Channel,
					  ushort BufId, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContReadChannelToFile (ushort CardNumber, ushort Channel, ushort BufId,
					  string FileName, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContReadMultiChannelsToFile (ushort CardNumber, ushort NumChans, ushort[] Chans,
					  ushort BufId, string FileName, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContScanChannelsToFile (ushort CardNumber, ushort Channel, ushort BufId,
					  string FileName, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort SyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContStatus (ushort CardNumber, out ushort Status);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContVScale (ushort wCardNumber, ushort adRange, short[] readingArray, double[] voltageArray, int count);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncCheck (ushort CardNumber, out byte Stopped, out uint AccessCnt);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncClear(ushort CardNumber, out uint StartPos, out uint AccessCnt);
 	[DllImport("D2K-Dask64.dll")]
 	public static extern short D2K_AI_AsyncClearEx(ushort CardNumber, out uint StartPos, out uint AccessCnt, uint NoWait);
    	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AI_AsyncDblBufferHalfReady(ushort CardNumber, out byte HalfReady, out byte StopFlag);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncDblBufferMode (ushort CardNumber, bool Enable);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncDblBufferToFile (ushort CardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContBufferSetup (ushort wCardNumber, short[] pwBuffer, uint dwReadCount, out ushort BufferId);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContBufferReset (ushort wCardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_MuxScanSetup (ushort wCardNumber, ushort wNumChans, ushort[] pwChans, ushort[] pwAdRange_RefGnds);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ReadMuxScan (ushort wCardNumber, ushort[] pwBuffer);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContMuxScan (ushort wCardNumber, ushort BufId, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort wSyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_ContMuxScanToFile (ushort wCardNumber, ushort BufId, string fileName, uint ReadScans, uint ScanIntrv, uint SampIntrv, ushort wSyncMode);
	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AI_EventCallBack_x64(ushort wCardNumber, short mode, ushort EventType, MulticastDelegate callbackAddr);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncReTrigNextReady (ushort wCardNumber, out byte trgReady, out byte StopFlag, out ushort RdyTrigCnt);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncReTrigNextReadyEx (ushort wCardNumber, out byte trgReady, out byte StopFlag, out uint RdyTrigCnt);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncDblBufferHandled (ushort wCardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_AsyncDblBufferOverrun (ushort wCardNumber, ushort op, out ushort overrunFlag);
	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AI_SetTimeout(ushort wCardNumber, uint msec);
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_CH_Config (ushort wCardNumber, ushort wChannel, ushort wOutputPolarity, ushort wIntOrExtRef, double refVoltage);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Config (ushort wCardNumber, ushort ConfigCtrl, ushort TrigCtrl, ushort ReTrgCnt, ushort DLY1Cnt, ushort DLY2Cnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_PostTrig_Config (ushort wCardNumber, ushort ClkSrc, ushort TrigSrcCtrl, ushort DLY2Ctrl, ushort DLY2Cnt, ushort ReTrgEn, ushort ReTrgCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_DelayTrig_Config (ushort wCardNumber, ushort ClkSrc, ushort TrigSrcCtrl, ushort DLY1Cnt, ushort DLY2Ctrl, ushort DLY2Cnt, ushort ReTrgEn, ushort ReTrgCnt, bool AutoResetBuf);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_InitialMemoryAllocated (ushort CardNumber, out uint MemSize);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_WriteChannel (ushort CardNumber, ushort Channel, short Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_VWriteChannel (ushort CardNumber, ushort Channel, double Voltage);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_VoltScale (ushort CardNumber, ushort Channel, double Voltage, out short binValue);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContWriteChannel (ushort wCardNumber, ushort wChannel,
					  ushort BufId, uint dwUpdateCount, uint wIterations, uint dwCHUI, ushort definite, ushort wSyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContWriteMultiChannels (ushort wCardNumber, ushort wNumChans, ushort[] pwChans,
					  ushort BufId, uint dwUpdateCount, uint wIterations, uint dwCHUI, ushort definite, ushort wSyncMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_AsyncCheck (ushort CardNumber, out byte Stopped, out uint WriteCnt);
	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AO_AsyncClear(ushort CardNumber, out uint WriteCnt, ushort stop_mode);
    	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AO_AsyncClearEx(ushort CardNumber, out uint WriteCnt, ushort stop_mode, uint NoWait);
    	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AO_AsyncDblBufferHalfReady(ushort CardNumber, out byte HalfReady);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_AsyncDblBufferMode (ushort CardNumber, bool Enable);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_SimuWriteChannel (ushort wCardNumber, ushort wNumChans, ushort[] pwBuffer);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContBufferSetup (ushort wCardNumber, short[] pwBuffer, uint dwWriteCount, out ushort BufferId);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContBufferReset (ushort wCardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContStatus (ushort CardNumber, out ushort Status);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContBufferComposeAll (ushort wCardNumber, ushort group, uint dwUpdateCount, short[] ConBuffer, short[] pwBuffer, bool fifoload);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_ContBufferCompose (ushort wCardNumber, ushort group, ushort wChannel, uint dwUpdateCount, short[] ConBuffer, short[] pwBuffer, bool fifoload);
	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AO_EventCallBack_x64(ushort wCardNumber, short mode, short EventType, MulticastDelegate callbackAddr);
    	[DllImport("D2K-Dask64.dll")]
    	public static extern short D2K_AO_SetTimeout(ushort wCardNumber, uint msec);
    /*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_Setup (ushort wCardNumber, ushort group, ushort wNumChans, ushort[] pwChans);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_Update (ushort CardNumber,  ushort group, short[] pwBuffer);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_VUpdate (ushort CardNumber,  ushort group, double[] pVoltage);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_FIFOLoad (ushort wCardNumber, ushort group, ushort BufId, uint dwWriteCount);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_FIFOLoad_2 (ushort wCardNumber, ushort group, ushort BufId, uint dwWriteCount);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_WFM_StopConfig (ushort wCardNumber, ushort group, ushort stopSrc, ushort stopMode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_WFM_Start (ushort wardNumber, ushort group, ushort fstBufIdOrNotUsed, ushort sndBufId,
					  uint dwUpdateCount, uint wIterations, uint dwCHUI, ushort definite);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_WFM_AsyncCheck (ushort CardNumber, ushort group, out byte Stopped, out uint WriteCnt);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_Group_WFM_AsyncClear (ushort CardNumber, ushort group, out uint WriteCnt, ushort stop_mode);
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DI_ReadLine (ushort CardNumber, ushort Port, ushort Line, out ushort State);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DI_ReadPort (ushort CardNumber, ushort Port, out uint Value);
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DO_WriteLine (ushort CardNumber, ushort Port, ushort Line, ushort Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DO_WritePort (ushort CardNumber, ushort Port, uint Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DO_ReadLine (ushort CardNumber, ushort Port, ushort Line, out ushort Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DO_ReadPort (ushort CardNumber, ushort Port, out uint Value);
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DIO_PortConfig (ushort CardNumber, ushort Port, ushort Direction);
	[DllImport("D2K-Dask64.dll")]	
	public static extern short D2K_DIO_LineConfig (ushort CardNumber, ushort Port, uint Line, ushort Direction);
	[DllImport("D2K-Dask64.dll")]	
	public static extern short D2K_DIO_LinesConfig (ushort CardNumber, ushort Port, uint Linesdirmap);		
	/*---------------------------------------------------------------------------*/
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_Setup (ushort wCardNumber, ushort wGCtr, ushort wMode, byte SrcCtrl, byte PolCtrl, ushort LReg1_Val, ushort LReg2_Val);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_SetupEx (ushort wCardNumber, ushort wGCtr, ushort wMode, byte SrcCtrl, byte PolCtrl, uint LReg1_Val, uint LReg2_Val);	
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_Control (ushort wCardNumber, ushort wGCtr, ushort ParamID, ushort Value);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_Reset (ushort wCardNumber, ushort wGCtr);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_Read (ushort wCardNumber, ushort wGCtr, out uint pValue);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_GCTR_Status (ushort wCardNumber, ushort wGCtr, out ushort pValue);

	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_SSI_SourceConn (ushort wCardNumber, ushort sigCode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_SSI_SourceDisConn (ushort wCardNumber, ushort sigCode);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_SSI_SourceClear (ushort wCardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Route_Signal (ushort wCardNumber, ushort signal, ushort polarity, ushort Line, ushort dir);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Signal_DisConn (ushort wCardNumber, ushort signal, ushort polarity, ushort Line);
	
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2205_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float da0v_err, out float da5v_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2205_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2206_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float da0v_err, out float da5v_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2206_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2213_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2214_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float da0v_err, out float da5v_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2214_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2010_Acquire_AD_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2010_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2005_Acquire_AD_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2005_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2006_Acquire_AD_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2006_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2016_Acquire_AD_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2016_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2204_Acquire_DA_Error(ushort wCardNumber, ushort channel, ushort polarity, out float da0v_err, out float da5v_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2204_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ2208_Acquire_AD_Error(ushort wCardNumber, out float gain_err, out float bioffset_err, out float unioffset_err, out float hg_bios_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ250X_Acquire_DA_Error(short wCardNumber, ushort channel, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short DAQ250X_Acquire_AD_Error(short wCardNumber, ushort polarity, out float gain_err, out float offset_err);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DB_Auto_Calibration_ALL(ushort wCardNumber);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_EEPROM_CAL_Constant_Update(ushort wCardNumber, ushort bank);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Load_CAL_Data(ushort wCardNumber, ushort bank);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Set_Default_Load_Area(ushort wCardNumber, ushort bank);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_Get_Default_Load_Area(ushort wCardNumber);

	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AI_GetEvent(ushort wCardNumber, out long hEvent);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_AO_GetEvent(ushort wCardNumber, out long hEvent);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DI_GetEvent(ushort wCardNumber, out long hEvent);
	[DllImport("D2K-Dask64.dll")]
	public static extern short D2K_DO_GetEvent(ushort wCardNumber, out long hEvent);
}
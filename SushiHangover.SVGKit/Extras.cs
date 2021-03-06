﻿using System;

namespace SushiHangover.SVGKit
{
	//typedef enum SVG_PRESERVEASPECTRATIO
	//{
	//	// Alignment Types
	//	SVG_PRESERVEASPECTRATIO_UNKNOWN = 0,
	//	SVG_PRESERVEASPECTRATIO_NONE = 1,
	//	SVG_PRESERVEASPECTRATIO_XMINYMIN = 2,
	//	SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3,
	//	SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4,
	//	SVG_PRESERVEASPECTRATIO_XMINYMID = 5,
	//	SVG_PRESERVEASPECTRATIO_XMIDYMID = 6,
	//	SVG_PRESERVEASPECTRATIO_XMAXYMID = 7,
	//	SVG_PRESERVEASPECTRATIO_XMINYMAX = 8,
	//	SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9,
	//	SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10
	//}
	//SVG_PRESERVEASPECTRATIO;

	public enum SVG_PRESERVEASPECTRATIO : uint
	{
		Unknown = 0,
		None = 1,
		XMinYMin = 2,
		XMidYMin = 3,
		XMaxYMin = 4,
		XMinYMid = 5,
		XMidYMid = 6,
		XMaxYMid = 7,
		XMinYMax = 8,
		XMidYMax = 9,
		XMaxYMax = 10
	}

	//typedef enum SVG_MEETORSLICE
	//{
	//	// Meet-or-slice Types
	//	SVG_MEETORSLICE_UNKNOWN = 0,
	//	SVG_MEETORSLICE_MEET = 1,
	//	SVG_MEETORSLICE_SLICE = 2
	//}
	//SVG_MEETORSLICE;

	public enum SVG_MEETORSLICE : uint
	{
		// Meet-or-slice Types
		Unknown = 0,
		Meet = 1,
		Slice = 2
	}
}

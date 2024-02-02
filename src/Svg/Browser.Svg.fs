namespace rec Browser.Types

open System
open Fable.Core

// ## SVG Elements

type [<Global;AllowNullLiteral>] SVGAElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract target: SVGAnimatedString with get, set

type [<AllowNullLiteral>] SVGAElementType =
    abstract prototype: SVGAElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAElement

type [<Global;AllowNullLiteral>] SVGAngle =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

type [<AllowNullLiteral>] SVGAngleType =
    abstract prototype: SVGAngle with get, set
    abstract SVG_ANGLETYPE_DEG: float with get, set
    abstract SVG_ANGLETYPE_GRAD: float with get, set
    abstract SVG_ANGLETYPE_RAD: float with get, set
    abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAngle()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAngle

type [<Global;AllowNullLiteral>] SVGAnimatedAngle =
    abstract animVal: SVGAngle with get, set
    abstract baseVal: SVGAngle with get, set

type [<AllowNullLiteral>] SVGAnimatedAngleType =
    abstract prototype: SVGAnimatedAngle with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedAngle()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedAngle

type [<Global;AllowNullLiteral>] SVGAnimatedBoolean =
    abstract animVal: bool with get, set
    abstract baseVal: bool with get, set

type [<AllowNullLiteral>] SVGAnimatedBooleanType =
    abstract prototype: SVGAnimatedBoolean with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedBoolean()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedBoolean

type [<Global;AllowNullLiteral>] SVGAnimatedEnumeration =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

type [<AllowNullLiteral>] SVGAnimatedEnumerationType =
    abstract prototype: SVGAnimatedEnumeration with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedEnumeration()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedEnumeration

type [<Global;AllowNullLiteral>] SVGAnimatedInteger =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

type [<AllowNullLiteral>] SVGAnimatedIntegerType =
    abstract prototype: SVGAnimatedInteger with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedInteger()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedInteger

type [<Global;AllowNullLiteral>] SVGAnimatedLength =
    abstract animVal: SVGLength with get, set
    abstract baseVal: SVGLength with get, set

type [<AllowNullLiteral>] SVGAnimatedLengthType =
    abstract prototype: SVGAnimatedLength with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedLength()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedLength

type [<Global;AllowNullLiteral>] SVGAnimatedLengthList =
    abstract animVal: SVGLengthList with get, set
    abstract baseVal: SVGLengthList with get, set

type [<AllowNullLiteral>] SVGAnimatedLengthListType =
    abstract prototype: SVGAnimatedLengthList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedLengthList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedLengthList

type [<Global;AllowNullLiteral>] SVGAnimatedNumber =
    abstract animVal: float with get, set
    abstract baseVal: float with get, set

type [<AllowNullLiteral>] SVGAnimatedNumberType =
    abstract prototype: SVGAnimatedNumber with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedNumber()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedNumber

type [<Global;AllowNullLiteral>] SVGAnimatedNumberList =
    abstract animVal: SVGNumberList with get, set
    abstract baseVal: SVGNumberList with get, set

type [<AllowNullLiteral>] SVGAnimatedNumberListType =
    abstract prototype: SVGAnimatedNumberList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedNumberList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedNumberList

type [<Global;AllowNullLiteral>] SVGAnimatedPreserveAspectRatio =
    abstract animVal: SVGPreserveAspectRatio with get, set
    abstract baseVal: SVGPreserveAspectRatio with get, set

type [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatioType =
    abstract prototype: SVGAnimatedPreserveAspectRatio with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedPreserveAspectRatio()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedPreserveAspectRatio

type [<Global;AllowNullLiteral>] SVGAnimatedRect =
    abstract animVal: SVGRect with get, set
    abstract baseVal: SVGRect with get, set

type [<AllowNullLiteral>] SVGAnimatedRectType =
    abstract prototype: SVGAnimatedRect with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedRect()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedRect

type [<Global;AllowNullLiteral>] SVGAnimatedString =
    abstract animVal: string with get, set
    abstract baseVal: string with get, set

type [<AllowNullLiteral>] SVGAnimatedStringType =
    abstract prototype: SVGAnimatedString with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedString()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedString

type [<Global;AllowNullLiteral>] SVGAnimatedTransformList =
    abstract animVal: SVGTransformList with get, set
    abstract baseVal: SVGTransformList with get, set

type [<AllowNullLiteral>] SVGAnimatedTransformListType =
    abstract prototype: SVGAnimatedTransformList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGAnimatedTransformList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGAnimatedTransformList

type [<Global;AllowNullLiteral>] SVGCircleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set

type [<AllowNullLiteral>] SVGCircleElementType =
    abstract prototype: SVGCircleElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGCircleElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGCircleElement

type [<Global;AllowNullLiteral>] SVGClipPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract clipPathUnits: SVGAnimatedEnumeration with get, set

type [<AllowNullLiteral>] SVGClipPathElementType =
    abstract prototype: SVGClipPathElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGClipPathElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGClipPathElement

type [<Global;AllowNullLiteral>] SVGComponentTransferFunctionElement =
    inherit SVGElement
    abstract amplitude: SVGAnimatedNumber with get, set
    abstract exponent: SVGAnimatedNumber with get, set
    abstract intercept: SVGAnimatedNumber with get, set
    abstract offset: SVGAnimatedNumber with get, set
    abstract slope: SVGAnimatedNumber with get, set
    abstract tableValues: SVGAnimatedNumberList with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set

type [<AllowNullLiteral>] SVGComponentTransferFunctionElementType =
    abstract prototype: SVGComponentTransferFunctionElement with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGComponentTransferFunctionElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGComponentTransferFunctionElement

type [<Global;AllowNullLiteral>] SVGDefsElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired

type [<AllowNullLiteral>] SVGDefsElementType =
    abstract prototype: SVGDefsElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGDefsElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGDefsElement

type [<Global;AllowNullLiteral>] SVGDescElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace

type [<AllowNullLiteral>] SVGDescElementType =
    abstract prototype: SVGDescElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGDescElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGDescElement

type [<Global;AllowNullLiteral>] SVGElement =
    inherit Element
    abstract id: string with get, set
    abstract onclick: (MouseEvent -> unit) with get, set
    abstract ondblclick: (MouseEvent -> unit) with get, set
    abstract onfocusin: (FocusEvent -> unit) with get, set
    abstract onfocusout: (FocusEvent -> unit) with get, set
    abstract onload: (Event -> unit) with get, set
    abstract onmousedown: (MouseEvent -> unit) with get, set
    abstract onmousemove: (MouseEvent -> unit) with get, set
    abstract onmouseout: (MouseEvent -> unit) with get, set
    abstract onmouseover: (MouseEvent -> unit) with get, set
    abstract onmouseup: (MouseEvent -> unit) with get, set
    abstract ownerSVGElement: SVGSVGElement with get, set
    abstract viewportElement: SVGElement with get, set
    abstract xmlbase: string with get, set
    abstract className: obj with get, set

type [<AllowNullLiteral>] SVGElementType =
    abstract prototype: SVGElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGElement

type [<Global;AllowNullLiteral>] SVGElementInstance =
    inherit EventTarget
    abstract childNodes: SVGElementInstanceList with get, set
    abstract correspondingElement: SVGElement with get, set
    abstract correspondingUseElement: SVGUseElement with get, set
    abstract firstChild: SVGElementInstance with get, set
    abstract lastChild: SVGElementInstance with get, set
    abstract nextSibling: SVGElementInstance with get, set
    abstract parentNode: SVGElementInstance with get, set
    abstract previousSibling: SVGElementInstance with get, set

type [<AllowNullLiteral>] SVGElementInstanceType =
    abstract prototype: SVGElementInstance with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGElementInstance()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGElementInstance

type [<Global;AllowNullLiteral>] SVGElementInstanceList =
    abstract length: float with get, set
    abstract item: index: float -> SVGElementInstance

type [<AllowNullLiteral>] SVGElementInstanceListType =
    abstract prototype: SVGElementInstanceList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGElementInstanceList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGElementInstanceList

type [<Global;AllowNullLiteral>] SVGEllipseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set

type [<AllowNullLiteral>] SVGEllipseElementType =
    abstract prototype: SVGEllipseElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGEllipseElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGEllipseElement

type [<Global;AllowNullLiteral>] SVGFEBlendElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract mode: SVGAnimatedEnumeration with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGFEBlendElementType =
    abstract prototype: SVGFEBlendElement with get, set
    abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_HUE: float with get, set
    abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEBlendElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEBlendElement

type [<Global;AllowNullLiteral>] SVGFEColorMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract values: SVGAnimatedNumberList with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGFEColorMatrixElementType =
    abstract prototype: SVGFEColorMatrixElement with get, set
    abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEColorMatrixElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEColorMatrixElement

type [<Global;AllowNullLiteral>] SVGFEComponentTransferElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set


type [<AllowNullLiteral>] SVGFEComponentTransferElementType =
    abstract prototype: SVGFEComponentTransferElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEComponentTransferElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEComponentTransferElement

type [<Global;AllowNullLiteral>] SVGFECompositeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract k1: SVGAnimatedNumber with get, set
    abstract k2: SVGAnimatedNumber with get, set
    abstract k3: SVGAnimatedNumber with get, set
    abstract k4: SVGAnimatedNumber with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set


type [<AllowNullLiteral>] SVGFECompositeElementType =
    abstract prototype: SVGFECompositeElement with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFECompositeElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFECompositeElement

type [<Global;AllowNullLiteral>] SVGFEConvolveMatrixElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract bias: SVGAnimatedNumber with get, set
    abstract divisor: SVGAnimatedNumber with get, set
    abstract edgeMode: SVGAnimatedEnumeration with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelMatrix: SVGAnimatedNumberList with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract orderX: SVGAnimatedInteger with get, set
    abstract orderY: SVGAnimatedInteger with get, set
    abstract preserveAlpha: SVGAnimatedBoolean with get, set
    abstract targetX: SVGAnimatedInteger with get, set
    abstract targetY: SVGAnimatedInteger with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set


type [<AllowNullLiteral>] SVGFEConvolveMatrixElementType =
    abstract prototype: SVGFEConvolveMatrixElement with get, set
    abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    abstract SVG_EDGEMODE_NONE: float with get, set
    abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    abstract SVG_EDGEMODE_WRAP: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEConvolveMatrixElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEConvolveMatrixElement

type [<Global;AllowNullLiteral>] SVGFEDiffuseLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract diffuseConstant: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set


type [<AllowNullLiteral>] SVGFEDiffuseLightingElementType =
    abstract prototype: SVGFEDiffuseLightingElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEDiffuseLightingElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEDiffuseLightingElement

type [<Global;AllowNullLiteral>] SVGFEDisplacementMapElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract in2: SVGAnimatedString with get, set
    abstract scale: SVGAnimatedNumber with get, set
    abstract xChannelSelector: SVGAnimatedEnumeration with get, set
    abstract yChannelSelector: SVGAnimatedEnumeration with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGFEDisplacementMapElementType =
    abstract prototype: SVGFEDisplacementMapElement with get, set
    abstract SVG_CHANNEL_A: float with get, set
    abstract SVG_CHANNEL_B: float with get, set
    abstract SVG_CHANNEL_G: float with get, set
    abstract SVG_CHANNEL_R: float with get, set
    abstract SVG_CHANNEL_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEDisplacementMapElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEDisplacementMapElement

type [<Global;AllowNullLiteral>] SVGFEDistantLightElement =
    inherit SVGElement
    abstract azimuth: SVGAnimatedNumber with get, set
    abstract elevation: SVGAnimatedNumber with get, set

type [<AllowNullLiteral>] SVGFEDistantLightElementType =
    abstract prototype: SVGFEDistantLightElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEDistantLightElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEDistantLightElement

type [<Global;AllowNullLiteral>] SVGFEFloodElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes


type [<AllowNullLiteral>] SVGFEFloodElementType =
    abstract prototype: SVGFEFloodElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEFloodElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEFloodElement

type [<Global;AllowNullLiteral>] SVGFEFuncAElement =
    inherit SVGComponentTransferFunctionElement


type [<AllowNullLiteral>] SVGFEFuncAElementType =
    abstract prototype: SVGFEFuncAElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEFuncAElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEFuncAElement

type [<Global;AllowNullLiteral>] SVGFEFuncBElement =
    inherit SVGComponentTransferFunctionElement


type [<AllowNullLiteral>] SVGFEFuncBElementType =
    abstract prototype: SVGFEFuncBElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEFuncBElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEFuncBElement

type [<Global;AllowNullLiteral>] SVGFEFuncGElement =
    inherit SVGComponentTransferFunctionElement


type [<AllowNullLiteral>] SVGFEFuncGElementType =
    abstract prototype: SVGFEFuncGElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEFuncGElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEFuncGElement

type [<Global;AllowNullLiteral>] SVGFEFuncRElement =
    inherit SVGComponentTransferFunctionElement


type [<AllowNullLiteral>] SVGFEFuncRElementType =
    abstract prototype: SVGFEFuncRElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEFuncRElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEFuncRElement

type [<Global;AllowNullLiteral>] SVGFEGaussianBlurElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract stdDeviationX: SVGAnimatedNumber with get, set
    abstract stdDeviationY: SVGAnimatedNumber with get, set
    abstract setStdDeviation: stdDeviationX: float * stdDeviationY: float -> unit


type [<AllowNullLiteral>] SVGFEGaussianBlurElementType =
    abstract prototype: SVGFEGaussianBlurElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEGaussianBlurElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEGaussianBlurElement

type [<Global;AllowNullLiteral>] SVGFEImageElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set


type [<AllowNullLiteral>] SVGFEImageElementType =
    abstract prototype: SVGFEImageElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEImageElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEImageElement

type [<Global;AllowNullLiteral>] SVGFEMergeElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes


type [<AllowNullLiteral>] SVGFEMergeElementType =
    abstract prototype: SVGFEMergeElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEMergeElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEMergeElement

type [<Global;AllowNullLiteral>] SVGFEMergeNodeElement =
    inherit SVGElement
    abstract in1: SVGAnimatedString with get, set

type [<AllowNullLiteral>] SVGFEMergeNodeElementType =
    abstract prototype: SVGFEMergeNodeElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEMergeNodeElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEMergeNodeElement

type [<Global;AllowNullLiteral>] SVGFEMorphologyElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract operator: SVGAnimatedEnumeration with get, set
    abstract radiusX: SVGAnimatedNumber with get, set
    abstract radiusY: SVGAnimatedNumber with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGFEMorphologyElementType =
    abstract prototype: SVGFEMorphologyElement with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEMorphologyElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEMorphologyElement

type [<Global;AllowNullLiteral>] SVGFEOffsetElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract dx: SVGAnimatedNumber with get, set
    abstract dy: SVGAnimatedNumber with get, set
    abstract in1: SVGAnimatedString with get, set


type [<AllowNullLiteral>] SVGFEOffsetElementType =
    abstract prototype: SVGFEOffsetElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEOffsetElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEOffsetElement

type [<Global;AllowNullLiteral>] SVGFEPointLightElement =
    inherit SVGElement
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

type [<AllowNullLiteral>] SVGFEPointLightElementType =
    abstract prototype: SVGFEPointLightElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFEPointLightElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFEPointLightElement

type [<Global;AllowNullLiteral>] SVGFESpecularLightingElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set
    abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    abstract specularConstant: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract surfaceScale: SVGAnimatedNumber with get, set


type [<AllowNullLiteral>] SVGFESpecularLightingElementType =
    abstract prototype: SVGFESpecularLightingElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFESpecularLightingElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFESpecularLightingElement

type [<Global;AllowNullLiteral>] SVGFESpotLightElement =
    inherit SVGElement
    abstract limitingConeAngle: SVGAnimatedNumber with get, set
    abstract pointsAtX: SVGAnimatedNumber with get, set
    abstract pointsAtY: SVGAnimatedNumber with get, set
    abstract pointsAtZ: SVGAnimatedNumber with get, set
    abstract specularExponent: SVGAnimatedNumber with get, set
    abstract x: SVGAnimatedNumber with get, set
    abstract y: SVGAnimatedNumber with get, set
    abstract z: SVGAnimatedNumber with get, set

type [<AllowNullLiteral>] SVGFESpotLightElementType =
    abstract prototype: SVGFESpotLightElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFESpotLightElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFESpotLightElement

type [<Global;AllowNullLiteral>] SVGFETileElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract in1: SVGAnimatedString with get, set


type [<AllowNullLiteral>] SVGFETileElementType =
    abstract prototype: SVGFETileElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFETileElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFETileElement

type [<Global;AllowNullLiteral>] SVGFETurbulenceElement =
    inherit SVGElement
    inherit SVGFilterPrimitiveStandardAttributes
    abstract baseFrequencyX: SVGAnimatedNumber with get, set
    abstract baseFrequencyY: SVGAnimatedNumber with get, set
    abstract numOctaves: SVGAnimatedInteger with get, set
    abstract seed: SVGAnimatedNumber with get, set
    abstract stitchTiles: SVGAnimatedEnumeration with get, set
    abstract ``type``: SVGAnimatedEnumeration with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGFETurbulenceElementType =
    abstract prototype: SVGFETurbulenceElement with get, set
    abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    abstract SVG_STITCHTYPE_STITCH: float with get, set
    abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFETurbulenceElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFETurbulenceElement

type [<Global;AllowNullLiteral>] SVGFilterElement =
    inherit SVGElement
    inherit SVGUnitTypes
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGURIReference
    inherit SVGExternalResourcesRequired
    abstract filterResX: SVGAnimatedInteger with get, set
    abstract filterResY: SVGAnimatedInteger with get, set
    abstract filterUnits: SVGAnimatedEnumeration with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract primitiveUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract setFilterRes: filterResX: float * filterResY: float -> unit


type [<AllowNullLiteral>] SVGFilterElementType =
    abstract prototype: SVGFilterElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGFilterElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGFilterElement

type [<Global;AllowNullLiteral>] SVGForeignObjectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGForeignObjectElementType =
    abstract prototype: SVGForeignObjectElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGForeignObjectElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGForeignObjectElement

type [<Global;AllowNullLiteral>] SVGGElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired


type [<AllowNullLiteral>] SVGGElementType =
    abstract prototype: SVGGElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGGElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGGElement

type [<Global;AllowNullLiteral>] SVGGradientElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract gradientTransform: SVGAnimatedTransformList with get, set
    abstract gradientUnits: SVGAnimatedEnumeration with get, set
    abstract spreadMethod: SVGAnimatedEnumeration with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGGradientElementType =
    abstract prototype: SVGGradientElement with get, set
    abstract SVG_SPREADMETHOD_PAD: float with get, set
    abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGGradientElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGGradientElement

type [<Global;AllowNullLiteral>] SVGImageElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract height: SVGAnimatedLength with get, set
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGImageElementType =
    abstract prototype: SVGImageElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGImageElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGImageElement

type [<Global;AllowNullLiteral>] SVGLength =
    abstract unitType: float with get, set
    abstract value: float with get, set
    abstract valueAsString: string with get, set
    abstract valueInSpecifiedUnits: float with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    abstract convertToSpecifiedUnits: unitType: float -> unit
    abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

type [<AllowNullLiteral>] SVGLengthType =
    abstract prototype: SVGLength with get, set
    abstract SVG_LENGTHTYPE_CM: float with get, set
    abstract SVG_LENGTHTYPE_EMS: float with get, set
    abstract SVG_LENGTHTYPE_EXS: float with get, set
    abstract SVG_LENGTHTYPE_IN: float with get, set
    abstract SVG_LENGTHTYPE_MM: float with get, set
    abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    abstract SVG_LENGTHTYPE_PC: float with get, set
    abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    abstract SVG_LENGTHTYPE_PT: float with get, set
    abstract SVG_LENGTHTYPE_PX: float with get, set
    abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGLength()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGLength

type [<Global;AllowNullLiteral>] SVGLengthList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGLength -> SVGLength
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGLength
    abstract initialize: newItem: SVGLength -> SVGLength
    abstract insertItemBefore: newItem: SVGLength * index: float -> SVGLength
    abstract removeItem: index: float -> SVGLength
    abstract replaceItem: newItem: SVGLength * index: float -> SVGLength

type [<AllowNullLiteral>] SVGLengthListType =
    abstract prototype: SVGLengthList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGLengthList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGLengthList

type [<Global;AllowNullLiteral>] SVGLineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGLineElementType =
    abstract prototype: SVGLineElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGLineElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGLineElement

type [<Global;AllowNullLiteral>] SVGLinearGradientElement =
    inherit SVGGradientElement
    abstract x1: SVGAnimatedLength with get, set
    abstract x2: SVGAnimatedLength with get, set
    abstract y1: SVGAnimatedLength with get, set
    abstract y2: SVGAnimatedLength with get, set

type [<AllowNullLiteral>] SVGLinearGradientElementType =
    abstract prototype: SVGLinearGradientElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGLinearGradientElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGLinearGradientElement

type [<Global;AllowNullLiteral>] SVGMarkerElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    abstract markerHeight: SVGAnimatedLength with get, set
    abstract markerUnits: SVGAnimatedEnumeration with get, set
    abstract markerWidth: SVGAnimatedLength with get, set
    abstract orientAngle: SVGAnimatedAngle with get, set
    abstract orientType: SVGAnimatedEnumeration with get, set
    abstract refX: SVGAnimatedLength with get, set
    abstract refY: SVGAnimatedLength with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    abstract setOrientToAngle: angle: SVGAngle -> unit
    abstract setOrientToAuto: unit -> unit


type [<AllowNullLiteral>] SVGMarkerElementType =
    abstract prototype: SVGMarkerElement with get, set
    abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGMarkerElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGMarkerElement

type [<Global;AllowNullLiteral>] SVGMaskElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract maskContentUnits: SVGAnimatedEnumeration with get, set
    abstract maskUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGMaskElementType =
    abstract prototype: SVGMaskElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGMaskElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGMaskElement

type [<Global;AllowNullLiteral>] SVGMatrix =
    abstract a: float with get, set
    abstract b: float with get, set
    abstract c: float with get, set
    abstract d: float with get, set
    abstract e: float with get, set
    abstract f: float with get, set
    abstract flipX: unit -> SVGMatrix
    abstract flipY: unit -> SVGMatrix
    abstract inverse: unit -> SVGMatrix
    abstract multiply: secondMatrix: SVGMatrix -> SVGMatrix
    abstract rotate: angle: float -> SVGMatrix
    abstract rotateFromVector: x: float * y: float -> SVGMatrix
    abstract scale: scaleFactor: float -> SVGMatrix
    abstract scaleNonUniform: scaleFactorX: float * scaleFactorY: float -> SVGMatrix
    abstract skewX: angle: float -> SVGMatrix
    abstract skewY: angle: float -> SVGMatrix
    abstract translate: x: float * y: float -> SVGMatrix

type [<AllowNullLiteral>] SVGMatrixType =
    abstract prototype: SVGMatrix with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGMatrix()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGMatrix

type [<Global;AllowNullLiteral>] SVGMetadataElement =
    inherit SVGElement


type [<AllowNullLiteral>] SVGMetadataElementType =
    abstract prototype: SVGMetadataElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGMetadataElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGMetadataElement

type [<Global;AllowNullLiteral>] SVGNumber =
    abstract value: float with get, set

type [<AllowNullLiteral>] SVGNumberType =
    abstract prototype: SVGNumber with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGNumber()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGNumber

type [<Global;AllowNullLiteral>] SVGNumberList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGNumber -> SVGNumber
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGNumber
    abstract initialize: newItem: SVGNumber -> SVGNumber
    abstract insertItemBefore: newItem: SVGNumber * index: float -> SVGNumber
    abstract removeItem: index: float -> SVGNumber
    abstract replaceItem: newItem: SVGNumber * index: float -> SVGNumber

type [<AllowNullLiteral>] SVGNumberListType =
    abstract prototype: SVGNumberList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGNumberList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGNumberList

type [<Global;AllowNullLiteral>] SVGPathElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPathData
    abstract createSVGPathSegArcAbs: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcAbs
    abstract createSVGPathSegArcRel: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcRel
    abstract createSVGPathSegClosePath: unit -> SVGPathSegClosePath
    abstract createSVGPathSegCurvetoCubicAbs: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicAbs
    abstract createSVGPathSegCurvetoCubicRel: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicRel
    abstract createSVGPathSegCurvetoCubicSmoothAbs: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothAbs
    abstract createSVGPathSegCurvetoCubicSmoothRel: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothRel
    abstract createSVGPathSegCurvetoQuadraticAbs: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticAbs
    abstract createSVGPathSegCurvetoQuadraticRel: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticRel
    abstract createSVGPathSegCurvetoQuadraticSmoothAbs: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothAbs
    abstract createSVGPathSegCurvetoQuadraticSmoothRel: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothRel
    abstract createSVGPathSegLinetoAbs: x: float * y: float -> SVGPathSegLinetoAbs
    abstract createSVGPathSegLinetoHorizontalAbs: x: float -> SVGPathSegLinetoHorizontalAbs
    abstract createSVGPathSegLinetoHorizontalRel: x: float -> SVGPathSegLinetoHorizontalRel
    abstract createSVGPathSegLinetoRel: x: float * y: float -> SVGPathSegLinetoRel
    abstract createSVGPathSegLinetoVerticalAbs: y: float -> SVGPathSegLinetoVerticalAbs
    abstract createSVGPathSegLinetoVerticalRel: y: float -> SVGPathSegLinetoVerticalRel
    abstract createSVGPathSegMovetoAbs: x: float * y: float -> SVGPathSegMovetoAbs
    abstract createSVGPathSegMovetoRel: x: float * y: float -> SVGPathSegMovetoRel
    abstract getPathSegAtLength: distance: float -> float
    abstract getPointAtLength: distance: float -> SVGPoint
    abstract getTotalLength: unit -> float


type [<AllowNullLiteral>] SVGPathElementType =
    abstract prototype: SVGPathElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathElement

type [<Global;AllowNullLiteral>] SVGPathSeg =
    abstract pathSegType: float with get, set
    abstract pathSegTypeAsLetter: string with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set

type [<AllowNullLiteral>] SVGPathSegType =
    abstract prototype: SVGPathSeg with get, set
    abstract PATHSEG_ARC_ABS: float with get, set
    abstract PATHSEG_ARC_REL: float with get, set
    abstract PATHSEG_CLOSEPATH: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    abstract PATHSEG_LINETO_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    abstract PATHSEG_LINETO_REL: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    abstract PATHSEG_MOVETO_ABS: float with get, set
    abstract PATHSEG_MOVETO_REL: float with get, set
    abstract PATHSEG_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSeg()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSeg

type [<Global;AllowNullLiteral>] SVGPathSegArcAbs =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegArcAbsType =
    abstract prototype: SVGPathSegArcAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegArcAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegArcAbs

type [<Global;AllowNullLiteral>] SVGPathSegArcRel =
    inherit SVGPathSeg
    abstract angle: float with get, set
    abstract largeArcFlag: bool with get, set
    abstract r1: float with get, set
    abstract r2: float with get, set
    abstract sweepFlag: bool with get, set
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegArcRelType =
    abstract prototype: SVGPathSegArcRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegArcRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegArcRel

type [<Global;AllowNullLiteral>] SVGPathSegClosePath =
    inherit SVGPathSeg


type [<AllowNullLiteral>] SVGPathSegClosePathType =
    abstract prototype: SVGPathSegClosePath with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegClosePath()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegClosePath

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoCubicAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbsType =
    abstract prototype: SVGPathSegCurvetoCubicAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoCubicAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoCubicAbs

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoCubicRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set
    abstract y2: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoCubicRelType =
    abstract prototype: SVGPathSegCurvetoCubicRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoCubicRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoCubicRel

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoCubicSmoothAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoCubicSmoothAbs

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x2: float with get, set
    abstract y: float with get, set
    abstract y2: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRelType =
    abstract prototype: SVGPathSegCurvetoCubicSmoothRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoCubicSmoothRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoCubicSmoothRel

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoQuadraticAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoQuadraticAbs

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoQuadraticRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract x1: float with get, set
    abstract y: float with get, set
    abstract y1: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoQuadraticRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoQuadraticRel

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbsType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoQuadraticSmoothAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothAbs

type [<Global;AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRelType =
    abstract prototype: SVGPathSegCurvetoQuadraticSmoothRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegCurvetoQuadraticSmoothRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothRel

type [<Global;AllowNullLiteral>] SVGPathSegLinetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoAbsType =
    abstract prototype: SVGPathSegLinetoAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoAbs

type [<Global;AllowNullLiteral>] SVGPathSegLinetoHorizontalAbs =
    inherit SVGPathSeg
    abstract x: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbsType =
    abstract prototype: SVGPathSegLinetoHorizontalAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoHorizontalAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoHorizontalAbs

type [<Global;AllowNullLiteral>] SVGPathSegLinetoHorizontalRel =
    inherit SVGPathSeg
    abstract x: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRelType =
    abstract prototype: SVGPathSegLinetoHorizontalRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoHorizontalRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoHorizontalRel

type [<Global;AllowNullLiteral>] SVGPathSegLinetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoRelType =
    abstract prototype: SVGPathSegLinetoRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoRel

type [<Global;AllowNullLiteral>] SVGPathSegLinetoVerticalAbs =
    inherit SVGPathSeg
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbsType =
    abstract prototype: SVGPathSegLinetoVerticalAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoVerticalAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoVerticalAbs

type [<Global;AllowNullLiteral>] SVGPathSegLinetoVerticalRel =
    inherit SVGPathSeg
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegLinetoVerticalRelType =
    abstract prototype: SVGPathSegLinetoVerticalRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegLinetoVerticalRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegLinetoVerticalRel

type [<Global;AllowNullLiteral>] SVGPathSegList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPathSeg -> SVGPathSeg
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPathSeg
    abstract initialize: newItem: SVGPathSeg -> SVGPathSeg
    abstract insertItemBefore: newItem: SVGPathSeg * index: float -> SVGPathSeg
    abstract removeItem: index: float -> SVGPathSeg
    abstract replaceItem: newItem: SVGPathSeg * index: float -> SVGPathSeg

type [<AllowNullLiteral>] SVGPathSegListType =
    abstract prototype: SVGPathSegList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegList

type [<Global;AllowNullLiteral>] SVGPathSegMovetoAbs =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegMovetoAbsType =
    abstract prototype: SVGPathSegMovetoAbs with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegMovetoAbs()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegMovetoAbs

type [<Global;AllowNullLiteral>] SVGPathSegMovetoRel =
    inherit SVGPathSeg
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGPathSegMovetoRelType =
    abstract prototype: SVGPathSegMovetoRel with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPathSegMovetoRel()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPathSegMovetoRel

type [<Global;AllowNullLiteral>] SVGPatternElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGURIReference
    inherit SVGUnitTypes
    abstract height: SVGAnimatedLength with get, set
    abstract patternContentUnits: SVGAnimatedEnumeration with get, set
    abstract patternTransform: SVGAnimatedTransformList with get, set
    abstract patternUnits: SVGAnimatedEnumeration with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGPatternElementType =
    abstract prototype: SVGPatternElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPatternElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPatternElement

type [<Global;AllowNullLiteral>] SVGPoint =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract matrixTransform: matrix: SVGMatrix -> SVGPoint

type [<AllowNullLiteral>] SVGPointType =
    abstract prototype: SVGPoint with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPoint()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPoint

type [<Global;AllowNullLiteral>] SVGPointList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGPoint -> SVGPoint
    abstract clear: unit -> unit
    abstract getItem: index: float -> SVGPoint
    abstract initialize: newItem: SVGPoint -> SVGPoint
    abstract insertItemBefore: newItem: SVGPoint * index: float -> SVGPoint
    abstract removeItem: index: float -> SVGPoint
    abstract replaceItem: newItem: SVGPoint * index: float -> SVGPoint

type [<AllowNullLiteral>] SVGPointListType =
    abstract prototype: SVGPointList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPointList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPointList

type [<Global;AllowNullLiteral>] SVGPolygonElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints


type [<AllowNullLiteral>] SVGPolygonElementType =
    abstract prototype: SVGPolygonElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPolygonElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPolygonElement

type [<Global;AllowNullLiteral>] SVGPolylineElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGAnimatedPoints


type [<AllowNullLiteral>] SVGPolylineElementType =
    abstract prototype: SVGPolylineElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPolylineElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPolylineElement

type [<Global;AllowNullLiteral>] SVGPreserveAspectRatio =
    abstract align: float with get, set
    abstract meetOrSlice: float with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set

type [<AllowNullLiteral>] SVGPreserveAspectRatioType =
    abstract prototype: SVGPreserveAspectRatio with get, set
    abstract SVG_MEETORSLICE_MEET: float with get, set
    abstract SVG_MEETORSLICE_SLICE: float with get, set
    abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGPreserveAspectRatio()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGPreserveAspectRatio

type [<Global;AllowNullLiteral>] SVGRadialGradientElement =
    inherit SVGGradientElement
    abstract cx: SVGAnimatedLength with get, set
    abstract cy: SVGAnimatedLength with get, set
    abstract fx: SVGAnimatedLength with get, set
    abstract fy: SVGAnimatedLength with get, set
    abstract r: SVGAnimatedLength with get, set

type [<AllowNullLiteral>] SVGRadialGradientElementType =
    abstract prototype: SVGRadialGradientElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGRadialGradientElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGRadialGradientElement

type [<Global;AllowNullLiteral>] SVGRect =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] SVGRectType =
    abstract prototype: SVGRect with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGRect()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGRect

type [<Global;AllowNullLiteral>] SVGRectElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract height: SVGAnimatedLength with get, set
    abstract rx: SVGAnimatedLength with get, set
    abstract ry: SVGAnimatedLength with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGRectElementType =
    abstract prototype: SVGRectElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGRectElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGRectElement

type [<Global;AllowNullLiteral>] SVGSVGElement =
    inherit SVGElement
    inherit DocumentEvent
    inherit SVGLocatable
    inherit SVGTests
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract contentScriptType: string with get, set
    abstract contentStyleType: string with get, set
    abstract currentScale: float with get, set
    abstract currentTranslate: SVGPoint with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract onabort: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set
    abstract onresize: (UIEvent -> unit) with get, set
    abstract onscroll: (UIEvent -> unit) with get, set
    abstract onunload: (Event -> unit) with get, set
    abstract onzoom: (SVGZoomEvent -> unit) with get, set
    abstract pixelUnitToMillimeterX: float with get, set
    abstract pixelUnitToMillimeterY: float with get, set
    abstract screenPixelToMillimeterX: float with get, set
    abstract screenPixelToMillimeterY: float with get, set
    abstract viewport: SVGRect with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set
    abstract checkEnclosure: element: SVGElement * rect: SVGRect -> bool
    abstract checkIntersection: element: SVGElement * rect: SVGRect -> bool
    abstract createSVGAngle: unit -> SVGAngle
    abstract createSVGLength: unit -> SVGLength
    abstract createSVGMatrix: unit -> SVGMatrix
    abstract createSVGNumber: unit -> SVGNumber
    abstract createSVGPoint: unit -> SVGPoint
    abstract createSVGRect: unit -> SVGRect
    abstract createSVGTransform: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract deselectAll: unit -> unit
    abstract forceRedraw: unit -> unit
    // abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    abstract getCurrentTime: unit -> float
    abstract getElementById: elementId: string -> Element
    abstract getEnclosureList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract getIntersectionList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    abstract pauseAnimations: unit -> unit
    abstract setCurrentTime: seconds: float -> unit
    abstract suspendRedraw: maxWaitMilliseconds: float -> float
    abstract unpauseAnimations: unit -> unit
    abstract unsuspendRedraw: suspendHandleID: float -> unit
    abstract unsuspendRedrawAll: unit -> unit


type [<AllowNullLiteral>] SVGSVGElementType =
    abstract prototype: SVGSVGElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGSVGElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGSVGElement

type [<Global;AllowNullLiteral>] SVGScriptElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract ``type``: string with get, set


type [<AllowNullLiteral>] SVGScriptElementType =
    abstract prototype: SVGScriptElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGScriptElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGScriptElement

type [<Global;AllowNullLiteral>] SVGStopElement =
    inherit SVGElement
    inherit SVGStylable
    abstract offset: SVGAnimatedNumber with get, set


type [<AllowNullLiteral>] SVGStopElementType =
    abstract prototype: SVGStopElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGStopElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGStopElement

type [<Global;AllowNullLiteral>] SVGStringList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: string -> string
    abstract clear: unit -> unit
    abstract getItem: index: float -> string
    abstract initialize: newItem: string -> string
    abstract insertItemBefore: newItem: string * index: float -> string
    abstract removeItem: index: float -> string
    abstract replaceItem: newItem: string * index: float -> string

type [<AllowNullLiteral>] SVGStringListType =
    abstract prototype: SVGStringList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGStringList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGStringList

type [<Global;AllowNullLiteral>] SVGStyleElement =
    inherit SVGElement
    inherit SVGLangSpace
    abstract media: string with get, set
    abstract title: string with get, set
    abstract ``type``: string with get, set


type [<AllowNullLiteral>] SVGStyleElementType =
    abstract prototype: SVGStyleElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGStyleElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGStyleElement

type [<Global;AllowNullLiteral>] SVGSwitchElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired


type [<AllowNullLiteral>] SVGSwitchElementType =
    abstract prototype: SVGSwitchElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGSwitchElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGSwitchElement

type [<Global;AllowNullLiteral>] SVGSymbolElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox


type [<AllowNullLiteral>] SVGSymbolElementType =
    abstract prototype: SVGSymbolElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGSymbolElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGSymbolElement

type [<Global;AllowNullLiteral>] SVGTSpanElement =
    inherit SVGTextPositioningElement


type [<AllowNullLiteral>] SVGTSpanElementType =
    abstract prototype: SVGTSpanElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTSpanElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTSpanElement

type [<Global;AllowNullLiteral>] SVGTextContentElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    abstract lengthAdjust: SVGAnimatedEnumeration with get, set
    abstract textLength: SVGAnimatedLength with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    abstract getCharNumAtPosition: point: SVGPoint -> float
    abstract getComputedTextLength: unit -> float
    abstract getEndPositionOfChar: charnum: float -> SVGPoint
    abstract getExtentOfChar: charnum: float -> SVGRect
    abstract getNumberOfChars: unit -> float
    abstract getRotationOfChar: charnum: float -> float
    abstract getStartPositionOfChar: charnum: float -> SVGPoint
    abstract getSubStringLength: charnum: float * nchars: float -> float
    abstract selectSubString: charnum: float * nchars: float -> unit


type [<AllowNullLiteral>] SVGTextContentElementType =
    abstract prototype: SVGTextContentElement with get, set
    abstract LENGTHADJUST_SPACING: float with get, set
    abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    abstract LENGTHADJUST_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTextContentElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTextContentElement

type [<Global;AllowNullLiteral>] SVGTextElement =
    inherit SVGTextPositioningElement
    inherit SVGTransformable


type [<AllowNullLiteral>] SVGTextElementType =
    abstract prototype: SVGTextElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTextElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTextElement

type [<Global;AllowNullLiteral>] SVGTextPathElement =
    inherit SVGTextContentElement
    inherit SVGURIReference
    abstract ``method``: SVGAnimatedEnumeration with get, set
    abstract spacing: SVGAnimatedEnumeration with get, set
    abstract startOffset: SVGAnimatedLength with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set


type [<AllowNullLiteral>] SVGTextPathElementType =
    abstract prototype: SVGTextPathElement with get, set
    abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTextPathElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTextPathElement

type [<Global;AllowNullLiteral>] SVGTextPositioningElement =
    inherit SVGTextContentElement
    abstract dx: SVGAnimatedLengthList with get, set
    abstract dy: SVGAnimatedLengthList with get, set
    abstract rotate: SVGAnimatedNumberList with get, set
    abstract x: SVGAnimatedLengthList with get, set
    abstract y: SVGAnimatedLengthList with get, set

type [<AllowNullLiteral>] SVGTextPositioningElementType =
    abstract prototype: SVGTextPositioningElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTextPositioningElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTextPositioningElement

type [<Global;AllowNullLiteral>] SVGTitleElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGLangSpace


type [<AllowNullLiteral>] SVGTitleElementType =
    abstract prototype: SVGTitleElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTitleElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTitleElement

type [<Global;AllowNullLiteral>] SVGTransform =
    abstract angle: float with get, set
    abstract matrix: SVGMatrix with get, set
    abstract ``type``: float with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    abstract setMatrix: matrix: SVGMatrix -> unit
    abstract setRotate: angle: float * cx: float * cy: float -> unit
    abstract setScale: sx: float * sy: float -> unit
    abstract setSkewX: angle: float -> unit
    abstract setSkewY: angle: float -> unit
    abstract setTranslate: tx: float * ty: float -> unit

type [<AllowNullLiteral>] SVGTransformType =
    abstract prototype: SVGTransform with get, set
    abstract SVG_TRANSFORM_MATRIX: float with get, set
    abstract SVG_TRANSFORM_ROTATE: float with get, set
    abstract SVG_TRANSFORM_SCALE: float with get, set
    abstract SVG_TRANSFORM_SKEWX: float with get, set
    abstract SVG_TRANSFORM_SKEWY: float with get, set
    abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTransform()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTransform

type [<Global;AllowNullLiteral>] SVGTransformList =
    abstract numberOfItems: float with get, set
    abstract appendItem: newItem: SVGTransform -> SVGTransform
    abstract clear: unit -> unit
    abstract consolidate: unit -> SVGTransform
    abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    abstract getItem: index: float -> SVGTransform
    abstract initialize: newItem: SVGTransform -> SVGTransform
    abstract insertItemBefore: newItem: SVGTransform * index: float -> SVGTransform
    abstract removeItem: index: float -> SVGTransform
    abstract replaceItem: newItem: SVGTransform * index: float -> SVGTransform

type [<AllowNullLiteral>] SVGTransformListType =
    abstract prototype: SVGTransformList with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGTransformList()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGTransformList

type [<Global;AllowNullLiteral>] SVGUnitTypes =
    abstract SVG_UNIT_TYPE_OBJECTBOUNDINGBOX: float with get, set
    abstract SVG_UNIT_TYPE_UNKNOWN: float with get, set
    abstract SVG_UNIT_TYPE_USERSPACEONUSE: float with get, set

type [<Global;AllowNullLiteral>] SVGUseElement =
    inherit SVGElement
    inherit SVGStylable
    inherit SVGTransformable
    inherit SVGTests
    inherit SVGLangSpace
    inherit SVGExternalResourcesRequired
    inherit SVGURIReference
    abstract animatedInstanceRoot: SVGElementInstance with get, set
    abstract height: SVGAnimatedLength with get, set
    abstract instanceRoot: SVGElementInstance with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set


type [<AllowNullLiteral>] SVGUseElementType =
    abstract prototype: SVGUseElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGUseElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGUseElement

type [<Global;AllowNullLiteral>] SVGViewElement =
    inherit SVGElement
    inherit SVGExternalResourcesRequired
    inherit SVGFitToViewBox
    inherit SVGZoomAndPan
    abstract viewTarget: SVGStringList with get, set


type [<AllowNullLiteral>] SVGViewElementType =
    abstract prototype: SVGViewElement with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGViewElement()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGViewElement

type [<Global;AllowNullLiteral>] SVGZoomAndPan =
    abstract zoomAndPan: float with get, set

type [<AllowNullLiteral>] SVGZoomAndPanType =
    abstract SVG_ZOOMANDPAN_DISABLE: float with get, set
    abstract SVG_ZOOMANDPAN_MAGNIFY: float with get, set
    abstract SVG_ZOOMANDPAN_UNKNOWN: float with get, set

type [<Global;AllowNullLiteral>] SVGZoomEvent =
    inherit UIEvent
    abstract newScale: float with get, set
    abstract newTranslate: SVGPoint with get, set
    abstract previousScale: float with get, set
    abstract previousTranslate: SVGPoint with get, set
    abstract zoomRectScreen: SVGRect with get, set

type [<AllowNullLiteral>] SVGZoomEventType =
    abstract prototype: SVGZoomEvent with get, set
    #if JAVASCRIPT
    [<WebSharper.Inline("new SVGZoomEvent()")>]
    #else
    [<Emit("new $0($1...)")>]
    #endif
    abstract Create: unit -> SVGZoomEvent

type [<Global;AllowNullLiteral>] SVGAnimatedPathData =
        abstract pathSegList: SVGPathSegList with get, set

type [<Global;AllowNullLiteral>] SVGAnimatedPoints =
    abstract animatedPoints: SVGPointList with get, set
    abstract points: SVGPointList with get, set

type [<Global;AllowNullLiteral>] SVGExternalResourcesRequired =
    abstract externalResourcesRequired: SVGAnimatedBoolean with get, set

type [<Global;AllowNullLiteral>] SVGFilterPrimitiveStandardAttributes =
    inherit SVGStylable
    abstract height: SVGAnimatedLength with get, set
    abstract result: SVGAnimatedString with get, set
    abstract width: SVGAnimatedLength with get, set
    abstract x: SVGAnimatedLength with get, set
    abstract y: SVGAnimatedLength with get, set

type [<Global;AllowNullLiteral>] SVGFitToViewBox =
    abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    abstract viewBox: SVGAnimatedRect with get, set

type [<Global;AllowNullLiteral>] SVGLangSpace =
    abstract xmllang: string with get, set
    abstract xmlspace: string with get, set

type [<Global;AllowNullLiteral>] SVGLocatable =
    abstract farthestViewportElement: SVGElement with get, set
    abstract nearestViewportElement: SVGElement with get, set
    abstract getBBox: unit -> SVGRect
    abstract getCTM: unit -> SVGMatrix
    abstract getScreenCTM: unit -> SVGMatrix
    abstract getTransformToElement: element: SVGElement -> SVGMatrix

type [<Global;AllowNullLiteral>] SVGStylable =
    abstract className: obj with get, set
    // abstract style: CSSStyleDeclaration with get, set

type [<Global;AllowNullLiteral>] SVGTests =
    abstract requiredExtensions: SVGStringList with get, set
    abstract requiredFeatures: SVGStringList with get, set
    abstract systemLanguage: SVGStringList with get, set
    abstract hasExtension: extension: string -> bool

type [<Global;AllowNullLiteral>] SVGTransformable =
    inherit SVGLocatable
    abstract transform: SVGAnimatedTransformList with get, set

type [<Global;AllowNullLiteral>] SVGURIReference =
    abstract href: SVGAnimatedString with get, set

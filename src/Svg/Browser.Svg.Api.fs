namespace Browser

#if JAVASCRIPT
open WebSharper
type GlobalAttribute = InlineAttribute
#else
open Fable.Core
#endif

open Browser.Types

[<AutoOpen>]
module Svg =

    let [<Global>] SVGAElement: SVGAElementType = jsNative
    let [<Global>] SVGAngle: SVGAngleType = jsNative
    let [<Global>] SVGAnimatedAngle: SVGAnimatedAngleType = jsNative
    let [<Global>] SVGAnimatedBoolean: SVGAnimatedBooleanType = jsNative
    let [<Global>] SVGAnimatedEnumeration: SVGAnimatedEnumerationType = jsNative
    let [<Global>] SVGAnimatedInteger: SVGAnimatedIntegerType = jsNative
    let [<Global>] SVGAnimatedLength: SVGAnimatedLengthType = jsNative
    let [<Global>] SVGAnimatedLengthList: SVGAnimatedLengthListType = jsNative
    let [<Global>] SVGAnimatedNumber: SVGAnimatedNumberType = jsNative
    let [<Global>] SVGAnimatedNumberList: SVGAnimatedNumberListType = jsNative
    let [<Global>] SVGAnimatedPreserveAspectRatio: SVGAnimatedPreserveAspectRatioType = jsNative
    let [<Global>] SVGAnimatedRect: SVGAnimatedRectType = jsNative
    let [<Global>] SVGAnimatedString: SVGAnimatedStringType = jsNative
    let [<Global>] SVGAnimatedTransformList: SVGAnimatedTransformListType = jsNative
    let [<Global>] SVGCircleElement: SVGCircleElementType = jsNative
    let [<Global>] SVGClipPathElement: SVGClipPathElementType = jsNative
    let [<Global>] SVGComponentTransferFunctionElement: SVGComponentTransferFunctionElementType = jsNative
    let [<Global>] SVGDefsElement: SVGDefsElementType = jsNative
    let [<Global>] SVGDescElement: SVGDescElementType = jsNative
    let [<Global>] SVGElement: SVGElementType = jsNative
    let [<Global>] SVGElementInstance: SVGElementInstanceType = jsNative
    let [<Global>] SVGElementInstanceList: SVGElementInstanceListType = jsNative
    let [<Global>] SVGEllipseElement: SVGEllipseElementType = jsNative
    let [<Global>] SVGFEBlendElement: SVGFEBlendElementType = jsNative
    let [<Global>] SVGFEColorMatrixElement: SVGFEColorMatrixElementType = jsNative
    let [<Global>] SVGFEComponentTransferElement: SVGFEComponentTransferElementType = jsNative
    let [<Global>] SVGFECompositeElement: SVGFECompositeElementType = jsNative
    let [<Global>] SVGFEConvolveMatrixElement: SVGFEConvolveMatrixElementType = jsNative
    let [<Global>] SVGFEDiffuseLightingElement: SVGFEDiffuseLightingElementType = jsNative
    let [<Global>] SVGFEDisplacementMapElement: SVGFEDisplacementMapElementType = jsNative
    let [<Global>] SVGFEDistantLightElement: SVGFEDistantLightElementType = jsNative
    let [<Global>] SVGFEFloodElement: SVGFEFloodElementType = jsNative
    let [<Global>] SVGFEFuncAElement: SVGFEFuncAElementType = jsNative
    let [<Global>] SVGFEFuncBElement: SVGFEFuncBElementType = jsNative
    let [<Global>] SVGFEFuncGElement: SVGFEFuncGElementType = jsNative
    let [<Global>] SVGFEFuncRElement: SVGFEFuncRElementType = jsNative
    let [<Global>] SVGFEGaussianBlurElement: SVGFEGaussianBlurElementType = jsNative
    let [<Global>] SVGFEImageElement: SVGFEImageElementType = jsNative
    let [<Global>] SVGFEMergeElement: SVGFEMergeElementType = jsNative
    let [<Global>] SVGFEMergeNodeElement: SVGFEMergeNodeElementType = jsNative
    let [<Global>] SVGFEMorphologyElement: SVGFEMorphologyElementType = jsNative
    let [<Global>] SVGFEOffsetElement: SVGFEOffsetElementType = jsNative
    let [<Global>] SVGFEPointLightElement: SVGFEPointLightElementType = jsNative
    let [<Global>] SVGFESpecularLightingElement: SVGFESpecularLightingElementType = jsNative
    let [<Global>] SVGFESpotLightElement: SVGFESpotLightElementType = jsNative
    let [<Global>] SVGFETileElement: SVGFETileElementType = jsNative
    let [<Global>] SVGFETurbulenceElement: SVGFETurbulenceElementType = jsNative
    let [<Global>] SVGFilterElement: SVGFilterElementType = jsNative
    let [<Global>] SVGForeignObjectElement: SVGForeignObjectElementType = jsNative
    let [<Global>] SVGGElement: SVGGElementType = jsNative
    let [<Global>] SVGGradientElement: SVGGradientElementType = jsNative
    let [<Global>] SVGImageElement: SVGImageElementType = jsNative
    let [<Global>] SVGLength: SVGLengthType = jsNative
    let [<Global>] SVGLengthList: SVGLengthListType = jsNative
    let [<Global>] SVGLineElement: SVGLineElementType = jsNative
    let [<Global>] SVGLinearGradientElement: SVGLinearGradientElementType = jsNative
    let [<Global>] SVGMarkerElement: SVGMarkerElementType = jsNative
    let [<Global>] SVGMaskElement: SVGMaskElementType = jsNative
    let [<Global>] SVGMatrix: SVGMatrixType = jsNative
    let [<Global>] SVGMetadataElement: SVGMetadataElementType = jsNative
    let [<Global>] SVGNumber: SVGNumberType = jsNative
    let [<Global>] SVGNumberList: SVGNumberListType = jsNative
    let [<Global>] SVGPathElement: SVGPathElementType = jsNative
    let [<Global>] SVGPathSeg: SVGPathSegType = jsNative
    let [<Global>] SVGPathSegArcAbs: SVGPathSegArcAbsType = jsNative
    let [<Global>] SVGPathSegArcRel: SVGPathSegArcRelType = jsNative
    let [<Global>] SVGPathSegClosePath: SVGPathSegClosePathType = jsNative
    let [<Global>] SVGPathSegCurvetoCubicAbs: SVGPathSegCurvetoCubicAbsType = jsNative
    let [<Global>] SVGPathSegCurvetoCubicRel: SVGPathSegCurvetoCubicRelType = jsNative
    let [<Global>] SVGPathSegCurvetoCubicSmoothAbs: SVGPathSegCurvetoCubicSmoothAbsType = jsNative
    let [<Global>] SVGPathSegCurvetoCubicSmoothRel: SVGPathSegCurvetoCubicSmoothRelType = jsNative
    let [<Global>] SVGPathSegCurvetoQuadraticAbs: SVGPathSegCurvetoQuadraticAbsType = jsNative
    let [<Global>] SVGPathSegCurvetoQuadraticRel: SVGPathSegCurvetoQuadraticRelType = jsNative
    let [<Global>] SVGPathSegCurvetoQuadraticSmoothAbs: SVGPathSegCurvetoQuadraticSmoothAbsType = jsNative
    let [<Global>] SVGPathSegCurvetoQuadraticSmoothRel: SVGPathSegCurvetoQuadraticSmoothRelType = jsNative
    let [<Global>] SVGPathSegLinetoAbs: SVGPathSegLinetoAbsType = jsNative
    let [<Global>] SVGPathSegLinetoHorizontalAbs: SVGPathSegLinetoHorizontalAbsType = jsNative
    let [<Global>] SVGPathSegLinetoHorizontalRel: SVGPathSegLinetoHorizontalRelType = jsNative
    let [<Global>] SVGPathSegLinetoRel: SVGPathSegLinetoRelType = jsNative
    let [<Global>] SVGPathSegLinetoVerticalAbs: SVGPathSegLinetoVerticalAbsType = jsNative
    let [<Global>] SVGPathSegLinetoVerticalRel: SVGPathSegLinetoVerticalRelType = jsNative
    let [<Global>] SVGPathSegList: SVGPathSegListType = jsNative
    let [<Global>] SVGPathSegMovetoAbs: SVGPathSegMovetoAbsType = jsNative
    let [<Global>] SVGPathSegMovetoRel: SVGPathSegMovetoRelType = jsNative
    let [<Global>] SVGPatternElement: SVGPatternElementType = jsNative
    let [<Global>] SVGPoint: SVGPointType = jsNative
    let [<Global>] SVGPointList: SVGPointListType = jsNative
    let [<Global>] SVGPolygonElement: SVGPolygonElementType = jsNative
    let [<Global>] SVGPolylineElement: SVGPolylineElementType = jsNative
    let [<Global>] SVGPreserveAspectRatio: SVGPreserveAspectRatioType = jsNative
    let [<Global>] SVGRadialGradientElement: SVGRadialGradientElementType = jsNative
    let [<Global>] SVGRect: SVGRectType = jsNative
    let [<Global>] SVGRectElement: SVGRectElementType = jsNative
    let [<Global>] SVGSVGElement: SVGSVGElementType = jsNative
    let [<Global>] SVGScriptElement: SVGScriptElementType = jsNative
    let [<Global>] SVGStopElement: SVGStopElementType = jsNative
    let [<Global>] SVGStringList: SVGStringListType = jsNative
    let [<Global>] SVGStyleElement: SVGStyleElementType = jsNative
    let [<Global>] SVGSwitchElement: SVGSwitchElementType = jsNative
    let [<Global>] SVGSymbolElement: SVGSymbolElementType = jsNative
    let [<Global>] SVGTSpanElement: SVGTSpanElementType = jsNative
    let [<Global>] SVGTextContentElement: SVGTextContentElementType = jsNative
    let [<Global>] SVGTextElement: SVGTextElementType = jsNative
    let [<Global>] SVGTextPathElement: SVGTextPathElementType = jsNative
    let [<Global>] SVGTextPositioningElement: SVGTextPositioningElementType = jsNative
    let [<Global>] SVGTitleElement: SVGTitleElementType = jsNative
    let [<Global>] SVGTransform: SVGTransformType = jsNative
    let [<Global>] SVGTransformList: SVGTransformListType = jsNative
    let [<Global>] SVGUnitTypes: SVGUnitTypes = jsNative
    let [<Global>] SVGUseElement: SVGUseElementType = jsNative
    let [<Global>] SVGViewElement: SVGViewElementType = jsNative
    let [<Global>] SVGZoomAndPan: SVGZoomAndPanType = jsNative
    let [<Global>] SVGZoomEvent: SVGZoomEventType = jsNative

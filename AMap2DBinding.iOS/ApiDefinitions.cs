using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

using MAMapKit;


namespace MAMapKit
{
    // typedef void (^AMapTileProjectionBlock)(int, int, int, int, int, int);
    delegate void AMapTileProjectionBlock(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);


    [Static]
    ////[Verify((ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const MAMapKitVersion;
        [Field("MAMapKitVersion", "__Internal")]
        NSString MAMapKitVersion { get; }

        // extern NSString *const MAMapKitName;
        [Field("MAMapKitName", "__Internal")]
        NSString MAMapKitName { get; }

        // extern const MAMapSize MAMapSizeWorld;
        [Field("MAMapSizeWorld", "__Internal")]
        IntPtr MAMapSizeWorld { get; }

        // extern const MAMapRect MAMapRectWorld;
        [Field("MAMapRectWorld", "__Internal")]
        IntPtr MAMapRectWorld { get; }

        // extern const MAMapRect MAMapRectNull;
        [Field("MAMapRectNull", "__Internal")]
        IntPtr MAMapRectNull { get; }

        // extern const MAMapRect MAMapRectZero;
        [Field("MAMapRectZero", "__Internal")]
        IntPtr MAMapRectZero { get; }
    }




    // @interface NSValueMAGeometryExtensions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_NSValueMAGeometryExtensions
    {
        // +(NSValue *)valueWithMAMapPoint:(MAMapPoint)mapPoint;
        [Static]
        [Export("valueWithMAMapPoint:")]
        NSValue ValueWithMAMapPoint(MAMapPoint mapPoint);

        // +(NSValue *)valueWithMAMapSize:(MAMapSize)mapSize;
        [Static]
        [Export("valueWithMAMapSize:")]
        NSValue ValueWithMAMapSize(MAMapSize mapSize);

        // +(NSValue *)valueWithMAMapRect:(MAMapRect)mapRect;
        [Static]
        [Export("valueWithMAMapRect:")]
        NSValue ValueWithMAMapRect(MAMapRect mapRect);

        // +(NSValue *)valueWithMACoordinate:(CLLocationCoordinate2D)coordinate;
        [Static]
        [Export("valueWithMACoordinate:")]
        NSValue ValueWithMACoordinate(CLLocationCoordinate2D coordinate);

        // -(MAMapPoint)MAMapPointValue;
        [Export("MAMapPointValue")]
        ////[Verify((MethodToProperty)]
        MAMapPoint MAMapPointValue();

        // -(MAMapSize)MAMapSizeValue;
        [Export("MAMapSizeValue")]
        ////[Verify((MethodToProperty)]
        MAMapSize MAMapSizeValue();

        // -(MAMapRect)MAMapRectValue;
        [Export("MAMapRectValue")]
        ////[Verify((MethodToProperty)]
        MAMapRect MAMapRectValue();

        // -(CLLocationCoordinate2D)MACoordinateValue;
        [Export("MACoordinateValue")]
        ////[Verify((MethodToProperty)]
        CLLocationCoordinate2D MACoordinateValue();
    }

    // @protocol MAAnnotation <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MAAnnotation
    {
        //// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        //[Abstract]
        //[Export("coordinate")]
        //CLLocationCoordinate2D Coordinate { get; }

        // @optional @property (readonly, copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @optional @property (readonly, copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; }

        // @optional -(void)setCoordinate:(CLLocationCoordinate2D)newCoordinate;
        [Export("setCoordinate:")]
        void SetCoordinate(CLLocationCoordinate2D newCoordinate);
    }

    // @protocol MAOverlay <MAAnnotation>
    [Protocol, Model]
    [BaseType(typeof(MAAnnotation))]
    interface MAOverlay //: IMAAnnotation
    {
        // @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        [Abstract]
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        // @required @property (readonly, nonatomic) MAMapRect boundingMapRect;
        [Abstract]
        [Export("boundingMapRect")]
        MAMapRect BoundingMapRect { get; }

        // @optional -(BOOL)intersectsMapRect:(MAMapRect)mapRect;
        [Export("intersectsMapRect:")]
        bool IntersectsMapRect(MAMapRect mapRect);
    }

    // @interface MAOverlayRenderer : NSObject
    [BaseType(typeof(NSObject))]
    interface MAOverlayRenderer
    {
        // @property (readonly, nonatomic) id<MAOverlay> overlay;
        [Export("overlay")]
        AMap2DBinding.iOS.MAOverlay Overlay { get; }

        // @property CGFloat alpha;
        [Export("alpha")]
        nfloat Alpha { get; set; }

        // @property (readonly) CGFloat contentScaleFactor;
        [Export("contentScaleFactor")]
        nfloat ContentScaleFactor { get; }

        // -(id)initWithOverlay:(id<MAOverlay>)overlay;
        [Export("initWithOverlay:")]
        IntPtr Constructor(AMap2DBinding.iOS.MAOverlay overlay);

        // -(CGPoint)pointForMapPoint:(MAMapPoint)mapPoint;
        [Export("pointForMapPoint:")]
        CGPoint PointForMapPoint(MAMapPoint mapPoint);

        // -(MAMapPoint)mapPointForPoint:(CGPoint)point;
        [Export("mapPointForPoint:")]
        MAMapPoint MapPointForPoint(CGPoint point);

        // -(CGRect)rectForMapRect:(MAMapRect)mapRect;
        [Export("rectForMapRect:")]
        CGRect RectForMapRect(MAMapRect mapRect);

        // -(MAMapRect)mapRectForRect:(CGRect)rect;
        [Export("mapRectForRect:")]
        MAMapRect MapRectForRect(CGRect rect);

        // -(BOOL)canDrawMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale;
        [Export("canDrawMapRect:zoomScale:")]
        bool CanDrawMapRect(MAMapRect mapRect, double zoomScale);

        // -(void)drawMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale inContext:(CGContextRef)context;
        [Export("drawMapRect:zoomScale:inContext:")]
        unsafe void DrawMapRect(MAMapRect mapRect, double zoomScale, IntPtr context);

        // -(void)setNeedsDisplay;
        [Export("setNeedsDisplay")]
        void SetNeedsDisplay();

        // -(void)setNeedsDisplayInMapRect:(MAMapRect)mapRect;
        [Export("setNeedsDisplayInMapRect:")]
        void SetNeedsDisplayInMapRect(MAMapRect mapRect);

        // -(void)setNeedsDisplayInMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale;
        [Export("setNeedsDisplayInMapRect:zoomScale:")]
        void SetNeedsDisplayInMapRect(MAMapRect mapRect, double zoomScale);
    }

    // @interface MAAnnotationView : UIView
    [BaseType(typeof(UIView))]
    interface MAAnnotationView
    {
        // @property (readonly, nonatomic) NSString * reuseIdentifier;
        [Export("reuseIdentifier")]
        string ReuseIdentifier { get; }

        // @property (assign, nonatomic) NSInteger zIndex;
        [Export("zIndex")]
        nint ZIndex { get; set; }

        // @property (nonatomic, strong) id<MAAnnotation> annotation;
        [Export("annotation", ArgumentSemantic.Strong)]
        MAAnnotation Annotation { get; set; }

        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (nonatomic) CGPoint centerOffset;
        [Export("centerOffset", ArgumentSemantic.Assign)]
        CGPoint CenterOffset { get; set; }

        // @property (nonatomic) CGPoint calloutOffset;
        [Export("calloutOffset", ArgumentSemantic.Assign)]
        CGPoint CalloutOffset { get; set; }

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (getter = isHighlighted, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { [Bind("isHighlighted")] get; set; }

        // @property (getter = isSelected, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (nonatomic) BOOL canShowCallout;
        [Export("canShowCallout")]
        bool CanShowCallout { get; set; }

        // @property (nonatomic, strong) UIView * leftCalloutAccessoryView;
        [Export("leftCalloutAccessoryView", ArgumentSemantic.Strong)]
        UIView LeftCalloutAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * rightCalloutAccessoryView;
        [Export("rightCalloutAccessoryView", ArgumentSemantic.Strong)]
        UIView RightCalloutAccessoryView { get; set; }

        // @property (getter = isDraggable, nonatomic) BOOL draggable;
        [Export("draggable")]
        bool Draggable { [Bind("isDraggable")] get; set; }

        // @property (nonatomic) MAAnnotationViewDragState dragState;
        [Export("dragState", ArgumentSemantic.Assign)]
        MAAnnotationViewDragState DragState { get; set; }

        // -(id)initWithAnnotation:(id<MAAnnotation>)annotation reuseIdentifier:(NSString *)reuseIdentifier;
        [Export("initWithAnnotation:reuseIdentifier:")]
        IntPtr Constructor(MAAnnotation annotation, string reuseIdentifier);

        // -(void)prepareForReuse;
        [Export("prepareForReuse")]
        void PrepareForReuse();

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);

        // -(void)setDragState:(MAAnnotationViewDragState)newDragState animated:(BOOL)animated;
        [Export("setDragState:animated:")]
        void SetDragState(MAAnnotationViewDragState newDragState, bool animated);
    }

    // @interface MAOverlayView : UIView
    [BaseType(typeof(UIView))]
    interface MAOverlayView
    {
        // -(id)initWithOverlay:(id<MAOverlay>)overlay;
        [Export("initWithOverlay:")]
        IntPtr Constructor(AMap2DBinding.iOS.MAOverlay overlay);

        // @property (readonly, nonatomic) id<MAOverlay> overlay;
        [Export("overlay")]
        MAOverlay Overlay { get; }

        // -(CGPoint)pointForMapPoint:(MAMapPoint)mapPoint;
        [Export("pointForMapPoint:")]
        CGPoint PointForMapPoint(MAMapPoint mapPoint);

        // -(MAMapPoint)mapPointForPoint:(CGPoint)point;
        [Export("mapPointForPoint:")]
        MAMapPoint MapPointForPoint(CGPoint point);

        // -(CGRect)rectForMapRect:(MAMapRect)mapRect;
        [Export("rectForMapRect:")]
        CGRect RectForMapRect(MAMapRect mapRect);

        // -(MAMapRect)mapRectForRect:(CGRect)rect;
        [Export("mapRectForRect:")]
        MAMapRect MapRectForRect(CGRect rect);

        // -(BOOL)canDrawMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale;
        [Export("canDrawMapRect:zoomScale:")]
        bool CanDrawMapRect(MAMapRect mapRect, double zoomScale);

        // -(void)drawMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale inContext:(CGContextRef)context;
        [Export("drawMapRect:zoomScale:inContext:")]
        unsafe void DrawMapRect(MAMapRect mapRect, double zoomScale, IntPtr context);

        // -(void)setNeedsDisplay;
        [Export("setNeedsDisplay")]
        void SetNeedsDisplay();

        // -(void)setNeedsDisplayInMapRect:(MAMapRect)mapRect;
        [Export("setNeedsDisplayInMapRect:")]
        void SetNeedsDisplayInMapRect(MAMapRect mapRect);

        // -(void)setNeedsDisplayInMapRect:(MAMapRect)mapRect zoomScale:(MAZoomScale)zoomScale;
        [Export("setNeedsDisplayInMapRect:zoomScale:")]
        void SetNeedsDisplayInMapRect(MAMapRect mapRect, double zoomScale);

        // @property CGFloat alpha;
        [Export("alpha")]
        nfloat Alpha { get; set; }

        // @property (readonly) CGFloat contentScaleFactor;
        [Export("contentScaleFactor")]
        nfloat ContentScaleFactor { get; }
    }

    // @interface MAMapView : UIView
    [BaseType(typeof(UIView))]
    interface MAMapView
    {
        [Wrap("WeakDelegate")]
        MAMapViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MAMapViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) MAMapType mapType;
        [Export("mapType", ArgumentSemantic.Assign)]
        MAMapType MapType { get; set; }

        // @property (assign, nonatomic) MAMapLanguage language;
        [Export("language", ArgumentSemantic.Assign)]
        MAMapLanguage Language { get; set; }

        // @property (getter = isShowTraffic, assign, nonatomic) BOOL showTraffic;
        [Export("showTraffic")]
        bool ShowTraffic { [Bind("isShowTraffic")] get; set; }

        // @property (getter = isScrollEnabled, assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

        // @property (getter = isZoomEnabled, assign, nonatomic) BOOL zoomEnabled;
        [Export("zoomEnabled")]
        bool ZoomEnabled { [Bind("isZoomEnabled")] get; set; }

        // @property (readonly, nonatomic) BOOL isAbroad;
        [Export("isAbroad")]
        bool IsAbroad { get; }

        // @property (assign, nonatomic) BOOL allowsAnnotationViewSorting;
        [Export("allowsAnnotationViewSorting")]
        bool AllowsAnnotationViewSorting { get; set; }

        // @property (nonatomic) CGPoint logoCenter;
        [Export("logoCenter", ArgumentSemantic.Assign)]
        CGPoint LogoCenter { get; set; }

        // @property (readonly, nonatomic) CGSize logoSize;
        [Export("logoSize")]
        CGSize LogoSize { get; }

        // @property (assign, nonatomic) BOOL showsCompass;
        [Export("showsCompass")]
        bool ShowsCompass { get; set; }

        // @property (nonatomic) CGPoint compassOrigin;
        [Export("compassOrigin", ArgumentSemantic.Assign)]
        CGPoint CompassOrigin { get; set; }

        // @property (readonly, nonatomic) CGSize compassSize;
        [Export("compassSize")]
        CGSize CompassSize { get; }

        // @property (nonatomic) BOOL showsScale;
        [Export("showsScale")]
        bool ShowsScale { get; set; }

        // @property (nonatomic) CGPoint scaleOrigin;
        [Export("scaleOrigin", ArgumentSemantic.Assign)]
        CGPoint ScaleOrigin { get; set; }

        // @property (readonly, nonatomic) CGSize scaleSize;
        [Export("scaleSize")]
        CGSize ScaleSize { get; }

        // @property (readonly, nonatomic) CGFloat metersPerPointForCurrentZoomLevel;
        [Export("metersPerPointForCurrentZoomLevel")]
        nfloat MetersPerPointForCurrentZoomLevel { get; }

        // @property (assign, nonatomic) CLLocationCoordinate2D centerCoordinate;
        [Export("centerCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D CenterCoordinate { get; set; }

        // @property (assign, nonatomic) MACoordinateRegion region;
        [Export("region", ArgumentSemantic.Assign)]
        MACoordinateRegion Region { get; set; }

        // @property (assign, nonatomic) MAMapRect visibleMapRect;
        [Export("visibleMapRect", ArgumentSemantic.Assign)]
        MAMapRect VisibleMapRect { get; set; }

        // @property (assign, nonatomic) MACoordinateRegion limitRegion;
        [Export("limitRegion", ArgumentSemantic.Assign)]
        MACoordinateRegion LimitRegion { get; set; }

        // @property (assign, nonatomic) MAMapRect limitMapRect;
        [Export("limitMapRect", ArgumentSemantic.Assign)]
        MAMapRect LimitMapRect { get; set; }

        // @property (assign, nonatomic) double zoomLevel;
        [Export("zoomLevel")]
        double ZoomLevel { get; set; }

        // @property (assign, nonatomic) double minZoomLevel;
        [Export("minZoomLevel")]
        double MinZoomLevel { get; set; }

        // @property (assign, nonatomic) double maxZoomLevel;
        [Export("maxZoomLevel")]
        double MaxZoomLevel { get; set; }

        // @property (getter = isShowsUserLocation, assign, nonatomic) BOOL showsUserLocation;
        [Export("showsUserLocation")]
        bool ShowsUserLocation { [Bind("isShowsUserLocation")] get; set; }

        // @property (readonly, nonatomic) MAUserLocation * userLocation;
        [Export("userLocation")]
        MAUserLocation UserLocation { get; }

        // @property (nonatomic) MAUserTrackingMode userTrackingMode;
        [Export("userTrackingMode", ArgumentSemantic.Assign)]
        MAUserTrackingMode UserTrackingMode { get; set; }

        // @property (readonly, getter = isUserLocationVisible, nonatomic) BOOL userLocationVisible;
        [Export("userLocationVisible")]
        bool UserLocationVisible { [Bind("isUserLocationVisible")] get; }

        // @property (readonly, nonatomic) NSArray * annotations;
        [Export("annotations")]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] Annotations { get; }

        // @property (copy, nonatomic) NSArray * selectedAnnotations;
        [Export("selectedAnnotations", ArgumentSemantic.Copy)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] SelectedAnnotations { get; set; }

        // @property (readonly, nonatomic) CGRect annotationVisibleRect;
        [Export("annotationVisibleRect")]
        CGRect AnnotationVisibleRect { get; }

        // @property (readonly, nonatomic) NSArray * overlays;
        [Export("overlays")]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] Overlays { get; }

        // -(void)setCompassImage:(UIImage *)image;
        [Export("setCompassImage:")]
        void SetCompassImage(UIImage image);

        // -(CGFloat)metersPerPointForZoomLevel:(CGFloat)zoomLevel;
        [Export("metersPerPointForZoomLevel:")]
        nfloat MetersPerPointForZoomLevel(nfloat zoomLevel);

        // -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate animated:(BOOL)animated;
        [Export("setCenterCoordinate:animated:")]
        void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, bool animated);

        // -(void)setRegion:(MACoordinateRegion)region animated:(BOOL)animated;
        [Export("setRegion:animated:")]
        void SetRegion(MACoordinateRegion region, bool animated);

        // -(MACoordinateRegion)regionThatFits:(MACoordinateRegion)region;
        [Export("regionThatFits:")]
        MACoordinateRegion RegionThatFits(MACoordinateRegion region);

        // -(void)setVisibleMapRect:(MAMapRect)mapRect animated:(BOOL)animated;
        [Export("setVisibleMapRect:animated:")]
        void SetVisibleMapRect(MAMapRect mapRect, bool animated);

        // -(void)setVisibleMapRect:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("setVisibleMapRect:edgePadding:animated:")]
        void SetVisibleMapRect(MAMapRect mapRect, UIEdgeInsets insets, bool animated);

        // -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect;
        [Export("mapRectThatFits:")]
        MAMapRect MapRectThatFits(MAMapRect mapRect);

        // -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets;
        [Export("mapRectThatFits:edgePadding:")]
        MAMapRect MapRectThatFits(MAMapRect mapRect, UIEdgeInsets insets);

        // -(void)setZoomLevel:(double)newZoomLevel animated:(BOOL)animated;
        [Export("setZoomLevel:animated:")]
        void SetZoomLevel(double newZoomLevel, bool animated);

        // -(void)setZoomLevel:(double)newZoomLevel atPivot:(CGPoint)pivot animated:(BOOL)animated;
        [Export("setZoomLevel:atPivot:animated:")]
        void SetZoomLevel(double newZoomLevel, CGPoint pivot, bool animated);

        // -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
        [Export("convertCoordinate:toPointToView:")]
        CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, UIView view);

        // -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
        [Export("convertPoint:toCoordinateFromView:")]
        CLLocationCoordinate2D ConvertPoint(CGPoint point, UIView view);

        // -(CGRect)convertRegion:(MACoordinateRegion)region toRectToView:(UIView *)view;
        [Export("convertRegion:toRectToView:")]
        CGRect ConvertRegion(MACoordinateRegion region, UIView view);

        // -(MACoordinateRegion)convertRect:(CGRect)rect toRegionFromView:(UIView *)view;
        [Export("convertRect:toRegionFromView:")]
        MACoordinateRegion ConvertRect(CGRect rect, UIView view);

        // -(void)setUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
        [Export("setUserTrackingMode:animated:")]
        void SetUserTrackingMode(MAUserTrackingMode mode, bool animated);

        // -(void)updateUserLocationRepresentation:(MAUserLocationRepresentation *)representation;
        [Export("updateUserLocationRepresentation:")]
        void UpdateUserLocationRepresentation(MAUserLocationRepresentation representation);

        // -(void)addAnnotation:(id<MAAnnotation>)annotation;
        [Export("addAnnotation:")]
        void AddAnnotation(MAAnnotation annotation);

        // -(void)addAnnotations:(NSArray *)annotations;
        [Export("addAnnotations:")]
        ////[Verify((StronglyTypedNSArray)]
        void AddAnnotations(NSObject[] annotations);

        // -(void)removeAnnotation:(id<MAAnnotation>)annotation;
        [Export("removeAnnotation:")]
        void RemoveAnnotation(MAAnnotation annotation);

        // -(void)removeAnnotations:(NSArray *)annotations;
        [Export("removeAnnotations:")]
        ////[Verify((StronglyTypedNSArray)]
        void RemoveAnnotations(NSObject[] annotations);

        // -(MAAnnotationView *)viewForAnnotation:(id<MAAnnotation>)annotation;
        [Export("viewForAnnotation:")]
        MAAnnotationView ViewForAnnotation(MAAnnotation annotation);

        // -(MAAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
        [Export("dequeueReusableAnnotationViewWithIdentifier:")]
        MAAnnotationView DequeueReusableAnnotationViewWithIdentifier(string identifier);

        // -(void)selectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
        [Export("selectAnnotation:animated:")]
        void SelectAnnotation(MAAnnotation annotation, bool animated);

        // -(void)deselectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
        [Export("deselectAnnotation:animated:")]
        void DeselectAnnotation(MAAnnotation annotation, bool animated);

        // -(NSSet *)annotationsInMapRect:(MAMapRect)mapRect;
        [Export("annotationsInMapRect:")]
        NSSet AnnotationsInMapRect(MAMapRect mapRect);

        // -(void)showAnnotations:(NSArray *)annotations animated:(BOOL)animated;
        [Export("showAnnotations:animated:")]
        ////[Verify((StronglyTypedNSArray)]
        void ShowAnnotations(NSObject[] annotations, bool animated);

        // -(void)showAnnotations:(NSArray *)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("showAnnotations:edgePadding:animated:")]
        ////[Verify((StronglyTypedNSArray)]
        void ShowAnnotations(NSObject[] annotations, UIEdgeInsets insets, bool animated);

        // -(MAOverlayRenderer *)rendererForOverlay:(id<MAOverlay>)overlay;
        [Export("rendererForOverlay:")]
        MAOverlayRenderer RendererForOverlay(AMap2DBinding.iOS.MAOverlay overlay);

        // -(MAOverlayView *)viewForOverlay:(id<MAOverlay>)overlay __attribute__((deprecated("use - (MAOverlayRenderer *)rendererForOverlay:(id <MAOverlay>)overlay instead")));
        [Export("viewForOverlay:")]
        MAOverlayView ViewForOverlay(AMap2DBinding.iOS.MAOverlay overlay);

        // -(void)addOverlay:(id<MAOverlay>)overlay;
        [Export("addOverlay:")]
        void AddOverlay(AMap2DBinding.iOS.MAOverlay overlay);

        // -(void)addOverlays:(NSArray *)overlays;
        [Export("addOverlays:")]
        ////[Verify((StronglyTypedNSArray)]
        void AddOverlays(NSObject[] overlays);

        // -(void)removeOverlay:(id<MAOverlay>)overlay;
        [Export("removeOverlay:")]
        void RemoveOverlay(AMap2DBinding.iOS.MAOverlay overlay);

        // -(void)removeOverlays:(NSArray *)overlays;
        [Export("removeOverlays:")]
        ////[Verify((StronglyTypedNSArray)]
        void RemoveOverlays(NSObject[] overlays);

        // -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index;
        [Export("insertOverlay:atIndex:")]
        void InsertOverlayAtIndex(AMap2DBinding.iOS.MAOverlay overlay, nuint index);

        // -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2;
        [Export("exchangeOverlayAtIndex:withOverlayAtIndex:")]
        void ExchangeOverlayAtIndex(nuint index1, nuint index2);

        // -(void)insertOverlay:(id<MAOverlay>)overlay aboveOverlay:(id<MAOverlay>)sibling;
        [Export("insertOverlay:aboveOverlay:")]
        void InsertOverlayAboveOverlay(AMap2DBinding.iOS.MAOverlay overlay, MAOverlay sibling);

        // -(void)insertOverlay:(id<MAOverlay>)overlay belowOverlay:(id<MAOverlay>)sibling;
        [Export("insertOverlay:belowOverlay:")]
        void InsertOverlayBelowOverlay(AMap2DBinding.iOS.MAOverlay overlay, MAOverlay sibling);

        // -(void)showOverlays:(NSArray *)overlays animated:(BOOL)animated;
        [Export("showOverlays:animated:")]
        ////[Verify((StronglyTypedNSArray)]
        void ShowOverlays(NSObject[] overlays, bool animated);

        // -(void)showOverlays:(NSArray *)overlays edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("showOverlays:edgePadding:animated:")]
        ////[Verify((StronglyTypedNSArray)]
        void ShowOverlays(NSObject[] overlays, UIEdgeInsets insets, bool animated);

        // -(void)clearDisk;
        [Export("clearDisk")]
        void ClearDisk();
    }

    // @interface Snapshot (MAMapView)
    [Category]
    [BaseType(typeof(MAMapView))]
    interface MAMapView_Snapshot
    {
        // -(UIImage *)takeSnapshotInRect:(CGRect)rect;
        [Export("takeSnapshotInRect:")]
        UIImage TakeSnapshotInRect(CGRect rect);

        // -(void)takeSnapshotInRect:(CGRect)rect withCompletionBlock:(void (^)(UIImage *, CGRect))block;
        [Export("takeSnapshotInRect:withCompletionBlock:")]
        void TakeSnapshotInRect(CGRect rect, Action<UIImage, CGRect> block);
    }

    // @interface LocationOption (MAMapView)
    [Category]
    [BaseType(typeof(MAMapView))]
    interface MAMapView_LocationOption
    {
        // @property (nonatomic) CLLocationDistance distanceFilter;
        [Export("distanceFilter")]
        double DistanceFilter();
        [Export("distanceFilter")]
        void SetDistanceFilter(double distanceFilter);


        // @property (nonatomic) CLLocationAccuracy desiredAccuracy;
        [Export("desiredAccuracy")]
        double DesiredAccuracy();
        [Export("desiredAccuracy")]
        void SetDesiredAccuracy(double desiredAccuracy);

        // @property (nonatomic) CLLocationDegrees headingFilter;
        [Export("headingFilter")]
        double HeadingFilter();
        [Export("headingFilter")]
        void SetHeadingFilter(double headingFilter);

        // @property (nonatomic) BOOL pausesLocationUpdatesAutomatically;
        [Export("pausesLocationUpdatesAutomatically")]
        bool PausesLocationUpdatesAutomatically();
        [Export("pausesLocationUpdatesAutomatically")]
        void PausesLocationUpdatesAutomatically(bool pausesLocationUpdatesAutomatically);

        // @property (nonatomic) BOOL allowsBackgroundLocationUpdates;
        [Export("allowsBackgroundLocationUpdates")]
        bool AllowsBackgroundLocationUpdates();
        [Export("allowsBackgroundLocationUpdates")]
        void SetAllowsBackgroundLocationUpdates(bool allowsBackgroundLocationUpdates);
    }

    // @protocol MAMapViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MAMapViewDelegate
    {
        // @optional -(void)mapView:(MAMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
        [Export("mapView:regionWillChangeAnimated:")]
        void MapViewRegionWillChangeAnimated(MAMapView mapView, bool animated);

        // @optional -(void)mapView:(MAMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
        [Export("mapView:regionDidChangeAnimated:")]
        void MapViewRegionDidChangeAnimated(MAMapView mapView, bool animated);

        // @optional -(void)mapView:(MAMapView *)mapView mapWillMoveByUser:(BOOL)wasUserAction;
        [Export("mapView:mapWillMoveByUser:")]
        void MapViewMapWillMoveByUser(MAMapView mapView, bool wasUserAction);

        // @optional -(void)mapView:(MAMapView *)mapView mapDidMoveByUser:(BOOL)wasUserAction;
        [Export("mapView:mapDidMoveByUser:")]
        void MapViewMapDidMoveByUser(MAMapView mapView, bool wasUserAction);

        // @optional -(void)mapView:(MAMapView *)mapView mapWillZoomByUser:(BOOL)wasUserAction;
        [Export("mapView:mapWillZoomByUser:")]
        void MapViewMapWillZoomByUser(MAMapView mapView, bool wasUserAction);

        // @optional -(void)mapView:(MAMapView *)mapView mapDidZoomByUser:(BOOL)wasUserAction;
        [Export("mapView:mapDidZoomByUser:")]
        void MapViewMapDidZoomByUser(MAMapView mapView, bool wasUserAction);

        // @optional -(void)mapView:(MAMapView *)mapView didSingleTappedAtCoordinate:(CLLocationCoordinate2D)coordinate;
        [Export("mapView:didSingleTappedAtCoordinate:")]
        void MapViewDidSingleTappedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

        // @optional -(void)mapView:(MAMapView *)mapView didLongPressedAtCoordinate:(CLLocationCoordinate2D)coordinate;
        [Export("mapView:didLongPressedAtCoordinate:")]
        void MapViewDidLongPressedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

        // @optional -(MAAnnotationView *)mapView:(MAMapView *)mapView viewForAnnotation:(id<MAAnnotation>)annotation;
        [Export("mapView:viewForAnnotation:")]
        MAAnnotationView MapViewViewForAnnotation(MAMapView mapView, MAAnnotation annotation);

        // @optional -(void)mapView:(MAMapView *)mapView didAddAnnotationViews:(NSArray *)views;
        [Export("mapView:didAddAnnotationViews:")]
        ////[Verify((StronglyTypedNSArray)]
        void MapViewDidAddAnnotationViews(MAMapView mapView, NSObject[] views);

        // @optional -(void)mapView:(MAMapView *)mapView didSelectAnnotationView:(MAAnnotationView *)view;
        [Export("mapView:didSelectAnnotationView:")]
        void MapViewDidSelectAnnotationView(MAMapView mapView, MAAnnotationView view);

        // @optional -(void)mapView:(MAMapView *)mapView didDeselectAnnotationView:(MAAnnotationView *)view;
        [Export("mapView:didDeselectAnnotationView:")]
        void MapViewDidDeselectAnnotationView(MAMapView mapView, MAAnnotationView view);

        // @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view calloutAccessoryControlTapped:(UIControl *)control;
        [Export("mapView:annotationView:calloutAccessoryControlTapped:")]
        void MapView(MAMapView mapView, MAAnnotationView view, UIControl control);

        // @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewCalloutTapped:(MAAnnotationView *)view;
        [Export("mapView:didAnnotationViewCalloutTapped:")]
        void MapView(MAMapView mapView, MAAnnotationView view);

        // @optional -(void)mapViewWillStartLocatingUser:(MAMapView *)mapView;
        [Export("mapViewWillStartLocatingUser:")]
        void MapViewWillStartLocatingUser(MAMapView mapView);

        // @optional -(void)mapViewDidStopLocatingUser:(MAMapView *)mapView;
        [Export("mapViewDidStopLocatingUser:")]
        void MapViewDidStopLocatingUser(MAMapView mapView);

        // @optional -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation updatingLocation:(BOOL)updatingLocation;
        [Export("mapView:didUpdateUserLocation:updatingLocation:")]
        void MapView(MAMapView mapView, MAUserLocation userLocation, bool updatingLocation);

        // @optional -(void)mapView:(MAMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
        [Export("mapView:didFailToLocateUserWithError:")]
        void MapView(MAMapView mapView, NSError error);

        // @optional -(void)mapView:(MAMapView *)mapView didChangeUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
        [Export("mapView:didChangeUserTrackingMode:animated:")]
        void MapView(MAMapView mapView, MAUserTrackingMode mode, bool animated);

        // @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view didChangeDragState:(MAAnnotationViewDragState)newState fromOldState:(MAAnnotationViewDragState)oldState;
        [Export("mapView:annotationView:didChangeDragState:fromOldState:")]
        void MapView(MAMapView mapView, MAAnnotationView view, MAAnnotationViewDragState newState, MAAnnotationViewDragState oldState);

        // @optional -(MAOverlayRenderer *)mapView:(MAMapView *)mapView rendererForOverlay:(id<MAOverlay>)overlay;
        [Export("mapView:rendererForOverlay:")]
        MAOverlayRenderer MapViewRendererForOverlay(MAMapView mapView, MAOverlay overlay);

        // @optional -(void)mapView:(MAMapView *)mapView didAddOverlayRenderers:(NSArray *)renderers;
        [Export("mapView:didAddOverlayRenderers:")]
        ////[Verify((StronglyTypedNSArray)]
        void MapViewDidAddOverlayRenderers(MAMapView mapView, NSObject[] renderers);

        // @optional -(MAOverlayView *)mapView:(MAMapView *)mapView viewForOverlay:(id<MAOverlay>)overlay __attribute__((deprecated("use - (MAOverlayRenderer *)mapView:(MAMapView *)mapView rendererForOverlay:(id <MAOverlay>)overlay instead")));
        [Export("mapView:viewForOverlay:")]
        MAOverlayView MapViewViewForOverlay(MAMapView mapView, MAOverlay overlay);

        // @optional -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation __attribute__((deprecated("use -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation updatingLocation:(BOOL)updatingLocation instead")));
        [Export("mapView:didUpdateUserLocation:")]
        void MapView(MAMapView mapView, MAUserLocation userLocation);

        // @optional -(void)mapView:(MAMapView *)mapView didAddOverlayViews:(NSArray *)overlayViews __attribute__((deprecated("use - (void)mapView:(MAMapView *)mapView didAddOverlayRenderers:(NSArray *)renderers instead")));
        [Export("mapView:didAddOverlayViews:")]
        ////[Verify((StronglyTypedNSArray)]
        void MapViewDidAddOverlayViews(MAMapView mapView, NSObject[] overlayViews);
    }

    // @interface MAShape : NSObject <MAAnnotation>
    [BaseType(typeof(NSObject))]
    interface MAShape //: IMAAnnotation
    {
        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; set; }
    }

    // @interface MAPointAnnotation : MAShape
    [BaseType(typeof(MAShape))]
    interface MAPointAnnotation
    {
        //// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
        //[Export("coordinate", ArgumentSemantic.Assign)]
        //CLLocationCoordinate2D Coordinate { get; set; }

        // @property (getter = isLockedToScreen, assign, nonatomic) BOOL lockedToScreen;
        [Export("lockedToScreen")]
        bool LockedToScreen { [Bind("isLockedToScreen")] get; set; }

        // @property (assign, nonatomic) CGPoint lockedScreenPoint;
        [Export("lockedScreenPoint", ArgumentSemantic.Assign)]
        CGPoint LockedScreenPoint { get; set; }
    }

    // @interface MAPinAnnotationView : MAAnnotationView
    [BaseType(typeof(MAAnnotationView))]
    interface MAPinAnnotationView
    {
        // @property (nonatomic) MAPinAnnotationColor pinColor;
        [Export("pinColor", ArgumentSemantic.Assign)]
        MAPinAnnotationColor PinColor { get; set; }

        // @property (nonatomic) BOOL animatesDrop;
        [Export("animatesDrop")]
        bool AnimatesDrop { get; set; }
    }

    // @interface MAUserLocation : NSObject <MAAnnotation>
    [BaseType(typeof(NSObject))]
    interface MAUserLocation //: IMAAnnotation
    {
        // @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
        [Export("updating")]
        bool Updating { [Bind("isUpdating")] get; }

        // @property (readonly, nonatomic) CLLocation * location;
        [Export("location")]
        CLLocation Location { get; }

        // @property (readonly, nonatomic) CLHeading * heading;
        [Export("heading")]
        CLHeading Heading { get; }

        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; set; }
    }

    // @interface MAUserLocationRepresentation : NSObject
    [BaseType(typeof(NSObject))]
    interface MAUserLocationRepresentation
    {
        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (assign, nonatomic) BOOL showsAccuracyRing;
        [Export("showsAccuracyRing")]
        bool ShowsAccuracyRing { get; set; }

        // @property (assign, nonatomic) BOOL showsHeadingIndicator;
        [Export("showsHeadingIndicator")]
        bool ShowsHeadingIndicator { get; set; }

        // @property (assign, nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (nonatomic, strong) UIColor * fillColor;
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (nonatomic, strong) UIColor * strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property (copy, nonatomic) NSArray * lineDashPattern;
        [Export("lineDashPattern", ArgumentSemantic.Copy)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] LineDashPattern { get; set; }
    }

    // @interface MAMultiPoint : MAShape
    [BaseType(typeof(MAShape))]
    interface MAMultiPoint
    {
        // @property (readonly, nonatomic) MAMapPoint * points;
        [Export("points")]
        unsafe MAMapPoint Points { get; }

        // @property (readonly, nonatomic) NSUInteger pointCount;
        [Export("pointCount")]
        nuint PointCount { get; }

        // -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
        [Export("getCoordinates:range:")]
        unsafe void GetCoordinates(CLLocationCoordinate2D coords, NSRange range);
    }

    // @interface MAOverlayPathRenderer : MAOverlayRenderer
    [BaseType(typeof(MAOverlayRenderer))]
    interface MAOverlayPathRenderer
    {
        // @property (strong) UIColor * fillColor;
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (strong) UIColor * strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property CGLineJoin lineJoin;
        [Export("lineJoin", ArgumentSemantic.Assign)]
        CGLineJoin LineJoin { get; set; }

        // @property CGLineCap lineCap;
        [Export("lineCap", ArgumentSemantic.Assign)]
        CGLineCap LineCap { get; set; }

        // @property CGFloat miterLimit;
        [Export("miterLimit")]
        nfloat MiterLimit { get; set; }

        // @property CGFloat lineDashPhase;
        [Export("lineDashPhase")]
        nfloat LineDashPhase { get; set; }

        // @property (copy) NSArray * lineDashPattern;
        [Export("lineDashPattern", ArgumentSemantic.Copy)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] LineDashPattern { get; set; }

        // @property CGPathRef path;
        [Export("path", ArgumentSemantic.Assign)]
        unsafe IntPtr Path { get; set; }
        //unsafe CGPathRef* Path { get; set; }

        // -(void)createPath;
        [Export("createPath")]
        void CreatePath();

        // -(void)invalidatePath;
        [Export("invalidatePath")]
        void InvalidatePath();

        // -(void)applyStrokePropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;
        [Export("applyStrokePropertiesToContext:atZoomScale:")]
        unsafe void ApplyStrokePropertiesToContext(IntPtr context, double zoomScale);

        // -(void)applyFillPropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;
        [Export("applyFillPropertiesToContext:atZoomScale:")]
        unsafe void ApplyFillPropertiesToContext(IntPtr context, double zoomScale);

        // -(void)strokePath:(CGPathRef)path inContext:(CGContextRef)context;
        [Export("strokePath:inContext:")]
        unsafe void StrokePath(IntPtr path, IntPtr context);
        //unsafe void StrokePath(CGPathRef* path, IntPtr context);

        // -(void)fillPath:(CGPathRef)path inContext:(CGContextRef)context;
        [Export("fillPath:inContext:")]
        unsafe void FillPath(IntPtr path, IntPtr context);

        //unsafe void FillPath(CGPathRef* path, IntPtr context);
    }

    // @interface MACircle : MAShape <MAOverlay>
    [BaseType(typeof(MAShape))]
    interface MACircle //: IMAOverlay
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        // @property (readonly, nonatomic) CLLocationDistance radius;
        [Export("radius")]
        double Radius { get; }

        // @property (readonly, nonatomic) MAMapRect boundingMapRect;
        [Export("boundingMapRect")]
        MAMapRect BoundingMapRect { get; }

        // +(instancetype)circleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
        [Static]
        [Export("circleWithCenterCoordinate:radius:")]
        MACircle CircleWithCenterCoordinate(CLLocationCoordinate2D coord, double radius);

        // +(instancetype)circleWithMapRect:(MAMapRect)mapRect;
        [Static]
        [Export("circleWithMapRect:")]
        MACircle CircleWithMapRect(MAMapRect mapRect);
    }

    // @interface MACircleRenderer : MAOverlayPathRenderer
    [BaseType(typeof(MAOverlayPathRenderer))]
    interface MACircleRenderer
    {
        // @property (readonly, nonatomic) MACircle * circle;
        [Export("circle")]
        MACircle Circle { get; }

        // -(instancetype)initWithCircle:(MACircle *)circle;
        [Export("initWithCircle:")]
        IntPtr Constructor(MACircle circle);
    }

    // @interface MAPolyline : MAMultiPoint <MAOverlay>
    [BaseType(typeof(MAMultiPoint))]
    interface MAPolyline //: IMAOverlay
    {
        // +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
        [Static]
        [Export("polylineWithPoints:count:")]
        unsafe MAPolyline PolylineWithPoints(MAMapPoint points, nuint count);

        // +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
        [Static]
        [Export("polylineWithCoordinates:count:")]
        unsafe MAPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);
    }

    // @interface MAGeodesicPolyline : MAPolyline
    [BaseType(typeof(MAPolyline))]
    interface MAGeodesicPolyline
    {
        // +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
        [Static]
        [Export("polylineWithPoints:count:")]
        unsafe MAGeodesicPolyline PolylineWithPoints(MAMapPoint points, nuint count);

        // +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
        [Static]
        [Export("polylineWithCoordinates:count:")]
        unsafe MAGeodesicPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);
    }

    // @interface MAPolylineRenderer : MAOverlayPathRenderer
    [BaseType(typeof(MAOverlayPathRenderer))]
    interface MAPolylineRenderer
    {
        // @property (readonly, nonatomic) MAPolyline * polyline;
        [Export("polyline")]
        MAPolyline Polyline { get; }

        // -(id)initWithPolyline:(MAPolyline *)polyline;
        [Export("initWithPolyline:")]
        IntPtr Constructor(MAPolyline polyline);
    }

    // @interface MAMultiPolyline : MAPolyline
    [BaseType(typeof(MAPolyline))]
    interface MAMultiPolyline
    {
        // @property (readonly, nonatomic, strong) NSArray * drawStyleIndexes;
        [Export("drawStyleIndexes", ArgumentSemantic.Strong)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] DrawStyleIndexes { get; }

        // +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray *)drawStyleIndexes;
        [Static]
        [Export("polylineWithPoints:count:drawStyleIndexes:")]
        ////[Verify((StronglyTypedNSArray)]
        unsafe MAMultiPolyline PolylineWithPoints(MAMapPoint points, nuint count, NSObject[] drawStyleIndexes);

        // +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray *)drawStyleIndexes;
        [Static]
        [Export("polylineWithCoordinates:count:drawStyleIndexes:")]
        ////[Verify((StronglyTypedNSArray)]
        unsafe MAMultiPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count, NSObject[] drawStyleIndexes);
    }

    // @interface MAMultiColoredPolylineRenderer : MAPolylineRenderer
    [BaseType(typeof(MAPolylineRenderer))]
    interface MAMultiColoredPolylineRenderer
    {
        // -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
        [Export("initWithMultiPolyline:")]
        IntPtr Constructor(MAMultiPolyline multiPolyline);

        // @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
        [Export("multiPolyline")]
        MAMultiPolyline MultiPolyline { get; }

        // @property (nonatomic, strong) NSArray * strokeColors;
        [Export("strokeColors", ArgumentSemantic.Strong)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] StrokeColors { get; set; }

        // @property (getter = isGradient, assign, nonatomic) BOOL gradient;
        [Export("gradient")]
        bool Gradient { [Bind("isGradient")] get; set; }
    }

    // @interface MAPolygon : MAMultiPoint <MAOverlay>
    [BaseType(typeof(MAMultiPoint))]
    interface MAPolygon //: IMAOverlay
    {
        // @property (readonly) NSArray * interiorPolygons;
        [Export("interiorPolygons")]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] InteriorPolygons { get; }

        // +(instancetype)polygonWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
        [Static]
        [Export("polygonWithPoints:count:")]
        unsafe MAPolygon PolygonWithPoints(MAMapPoint points, nuint count);

        // +(instancetype)polygonWithPoints:(MAMapPoint *)points count:(NSUInteger)count interiorPolygons:(NSArray *)interiorPolygons;
        [Static]
        [Export("polygonWithPoints:count:interiorPolygons:")]
        ////[Verify((StronglyTypedNSArray)]
        unsafe MAPolygon PolygonWithPoints(MAMapPoint points, nuint count, NSObject[] interiorPolygons);

        // +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
        [Static]
        [Export("polygonWithCoordinates:count:")]
        unsafe MAPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count);

        // +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count interiorPolygons:(NSArray *)interiorPolygons;
        [Static]
        [Export("polygonWithCoordinates:count:interiorPolygons:")]
        ////[Verify((StronglyTypedNSArray)]
        unsafe MAPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count, NSObject[] interiorPolygons);
    }

    // @interface MAPolygonRenderer : MAOverlayPathRenderer
    [BaseType(typeof(MAOverlayPathRenderer))]
    interface MAPolygonRenderer
    {
        // @property (readonly, nonatomic) MAPolygon * polygon;
        [Export("polygon")]
        MAPolygon Polygon { get; }

        // -(id)initWithPolygon:(MAPolygon *)polygon;
        [Export("initWithPolygon:")]
        IntPtr Constructor(MAPolygon polygon);
    }

    // @interface MAGroundOverlay : MAShape <MAOverlay>
    [BaseType(typeof(MAShape))]
    interface MAGroundOverlay //: IMAOverlay
    {
        // @property (readonly, nonatomic) UIImage * icon;
        [Export("icon")]
        UIImage Icon { get; }

        // @property (readonly, nonatomic) CGFloat zoomLevel;
        [Export("zoomLevel")]
        nfloat ZoomLevel { get; }

        // @property (readonly, nonatomic) MACoordinateBounds bounds;
        [Export("bounds")]
        MACoordinateBounds Bounds { get; }

        // +(instancetype)groundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
        [Static]
        [Export("groundOverlayWithBounds:icon:")]
        MAGroundOverlay GroundOverlayWithBounds(MACoordinateBounds bounds, UIImage icon);

        // +(instancetype)groundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
        [Static]
        [Export("groundOverlayWithCoordinate:zoomLevel:icon:")]
        MAGroundOverlay GroundOverlayWithCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);
    }

    // @interface MAGroundOverlayRenderer : MAOverlayRenderer
    [BaseType(typeof(MAOverlayRenderer))]
    interface MAGroundOverlayRenderer
    {
        // @property (readonly, nonatomic) MAGroundOverlay * groundOverlay;
        [Export("groundOverlay")]
        MAGroundOverlay GroundOverlay { get; }

        // -(instancetype)initWithGroundOverlay:(MAGroundOverlay *)groundOverlay;
        [Export("initWithGroundOverlay:")]
        IntPtr Constructor(MAGroundOverlay groundOverlay);
    }

    // @interface MATileOverlay : NSObject <MAOverlay>
    [BaseType(typeof(NSObject))]
    interface MATileOverlay //: IMAOverlay
    {
        // -(instancetype)initWithURLTemplate:(NSString *)URLTemplate;
        [Export("initWithURLTemplate:")]
        IntPtr Constructor(string URLTemplate);

        // @property CGSize tileSize;
        [Export("tileSize", ArgumentSemantic.Assign)]
        CGSize TileSize { get; set; }

        // @property NSInteger minimumZ;
        [Export("minimumZ")]
        nint MinimumZ { get; set; }

        // @property NSInteger maximumZ;
        [Export("maximumZ")]
        nint MaximumZ { get; set; }

        // @property (readonly) NSString * URLTemplate;
        [Export("URLTemplate")]
        string URLTemplate { get; }

        // @property (nonatomic) BOOL canReplaceMapContent;
        [Export("canReplaceMapContent")]
        bool CanReplaceMapContent { get; set; }

        // @property (nonatomic) MAMapRect boundingMapRect;
        [Export("boundingMapRect", ArgumentSemantic.Assign)]
        MAMapRect BoundingMapRect { get; set; }
    }

    // @interface CustomLoading (MATileOverlay)
    [Category]
    [BaseType(typeof(MATileOverlay))]
    interface MATileOverlay_CustomLoading
    {
        // -(NSURL *)URLForTilePath:(MATileOverlayPath)path;
        [Export("URLForTilePath:")]
        NSUrl URLForTilePath(MATileOverlayPath path);

        // -(void)loadTileAtPath:(MATileOverlayPath)path result:(void (^)(NSData *, NSError *))result;
        [Export("loadTileAtPath:result:")]
        void LoadTileAtPath(MATileOverlayPath path, Action<NSData, NSError> result);
    }

    // @interface MATileOverlayRenderer : MAOverlayRenderer
    [BaseType(typeof(MAOverlayRenderer))]
    interface MATileOverlayRenderer
    {
        // @property (readonly, nonatomic) MATileOverlay * tileOverlay;
        [Export("tileOverlay")]
        MATileOverlay TileOverlay { get; }

        // -(instancetype)initWithTileOverlay:(MATileOverlay *)overlay;
        [Export("initWithTileOverlay:")]
        IntPtr Constructor(MATileOverlay overlay);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();
    }

    // @interface MAHeatMapNode : NSObject
    [BaseType(typeof(NSObject))]
    interface MAHeatMapNode
    {
        // @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D Coordinate { get; set; }

        // @property (assign, nonatomic) float intensity;
        [Export("intensity")]
        float Intensity { get; set; }
    }

    // @interface MAHeatMapGradient : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface MAHeatMapGradient : INSCopying
    {
        // @property (readonly, nonatomic) NSArray * colors;
        [Export("colors")]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] Colors { get; }

        // @property (readonly, nonatomic) NSArray * startPoints;
        [Export("startPoints")]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] StartPoints { get; }

        // -(instancetype)initWithColor:(NSArray *)colors andWithStartPoints:(NSArray *)startPoints;
        [Export("initWithColor:andWithStartPoints:")]
        ////[Verify((StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] colors, NSObject[] startPoints);
    }

    // @interface MAHeatMapTileOverlay : MATileOverlay
    [BaseType(typeof(MATileOverlay))]
    interface MAHeatMapTileOverlay
    {
        // @property (nonatomic, strong) NSArray * data;
        [Export("data", ArgumentSemantic.Strong)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] Data { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }

        // @property (assign, nonatomic) CGFloat opacity;
        [Export("opacity")]
        nfloat Opacity { get; set; }

        // @property (nonatomic, strong) MAHeatMapGradient * gradient;
        [Export("gradient", ArgumentSemantic.Strong)]
        MAHeatMapGradient Gradient { get; set; }

        // @property (assign, nonatomic) BOOL allowRetinaAdapting;
        [Export("allowRetinaAdapting")]
        bool AllowRetinaAdapting { get; set; }
    }

    // @interface MAOverlayPathView : MAOverlayView
    [BaseType(typeof(MAOverlayView))]
    interface MAOverlayPathView
    {
        // @property (strong) UIColor * fillColor;
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (strong) UIColor * strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property CGLineJoin lineJoin;
        [Export("lineJoin", ArgumentSemantic.Assign)]
        CGLineJoin LineJoin { get; set; }

        // @property CGLineCap lineCap;
        [Export("lineCap", ArgumentSemantic.Assign)]
        CGLineCap LineCap { get; set; }

        // @property CGFloat miterLimit;
        [Export("miterLimit")]
        nfloat MiterLimit { get; set; }

        // @property CGFloat lineDashPhase;
        [Export("lineDashPhase")]
        nfloat LineDashPhase { get; set; }

        // @property (copy) NSArray * lineDashPattern;
        [Export("lineDashPattern", ArgumentSemantic.Copy)]
        ////[Verify((StronglyTypedNSArray)]
        NSObject[] LineDashPattern { get; set; }

        // -(void)createPath;
        [Export("createPath")]
        void CreatePath();

        // @property CGPathRef path;
        [Export("path", ArgumentSemantic.Assign)]
        unsafe IntPtr Path { get; set; }

        //unsafe CGPathRef* Path { get; set; }

        // -(void)invalidatePath;
        [Export("invalidatePath")]
        void InvalidatePath();

        // -(void)applyStrokePropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;
        [Export("applyStrokePropertiesToContext:atZoomScale:")]
        unsafe void ApplyStrokePropertiesToContext(IntPtr context, double zoomScale);

        // -(void)applyFillPropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;
        [Export("applyFillPropertiesToContext:atZoomScale:")]
        unsafe void ApplyFillPropertiesToContext(IntPtr context, double zoomScale);

        // -(void)strokePath:(CGPathRef)path inContext:(CGContextRef)context;
        [Export("strokePath:inContext:")]
        unsafe void StrokePath(IntPtr path, IntPtr context);

        //unsafe void StrokePath(CGPathRef* path, IntPtr context);

        // -(void)fillPath:(CGPathRef)path inContext:(CGContextRef)context;
        [Export("fillPath:inContext:")]
        unsafe void FillPath(IntPtr path, IntPtr context);
        //unsafe void FillPath(CGPathRef* path, IntPtr context);
    }

    // @interface MACircleView : MAOverlayPathView
    [BaseType(typeof(MAOverlayPathView))]
    interface MACircleView
    {
        // -(id)initWithCircle:(MACircle *)circle;
        [Export("initWithCircle:")]
        IntPtr Constructor(MACircle circle);

        // @property (readonly, nonatomic) MACircle * circle;
        [Export("circle")]
        MACircle Circle { get; }
    }

    // @interface MAPolylineView : MAOverlayPathView
    [BaseType(typeof(MAOverlayPathView))]
    interface MAPolylineView
    {
        // -(id)initWithPolyline:(MAPolyline *)polyline;
        [Export("initWithPolyline:")]
        IntPtr Constructor(MAPolyline polyline);

        // @property (readonly, nonatomic) MAPolyline * polyline;
        [Export("polyline")]
        MAPolyline Polyline { get; }
    }

    // @interface MAPolygonView : MAOverlayPathView
    [BaseType(typeof(MAOverlayPathView))]
    interface MAPolygonView
    {
        // -(id)initWithPolygon:(MAPolygon *)polygon;
        [Export("initWithPolygon:")]
        IntPtr Constructor(MAPolygon polygon);

        // @property (readonly, nonatomic) MAPolygon * polygon;
        [Export("polygon")]
        MAPolygon Polygon { get; }
    }

    // @interface MAGroundOverlayView : MAOverlayView
    [BaseType(typeof(MAOverlayView))]
    interface MAGroundOverlayView
    {
        // @property (readonly, nonatomic) MAGroundOverlay * groundOverlay;
        [Export("groundOverlay")]
        MAGroundOverlay GroundOverlay { get; }

        // -(id)initWithGroundOverlay:(MAGroundOverlay *)groundOverlay;
        [Export("initWithGroundOverlay:")]
        IntPtr Constructor(MAGroundOverlay groundOverlay);
    }

    // @interface MATileOverlayView : MAOverlayView
    [BaseType(typeof(MAOverlayView))]
    interface MATileOverlayView
    {
        // @property (readonly, nonatomic) MATileOverlay * tileOverlay;
        [Export("tileOverlay")]
        MATileOverlay TileOverlay { get; }

        // -(id)initWithTileOverlay:(MATileOverlay *)overlay;
        [Export("initWithTileOverlay:")]
        IntPtr Constructor(MATileOverlay overlay);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();
    }
}
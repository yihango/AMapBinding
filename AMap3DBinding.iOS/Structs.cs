using System;
using System.Runtime.InteropServices;
using CoreLocation;
using Foundation;
using ObjCRuntime;

using MAMapKit;

namespace MAMapKit
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateBounds
    {
        public CLLocationCoordinate2D northEast;

        public CLLocationCoordinate2D southWest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateSpan
    {
        public double latitudeDelta;

        public double longitudeDelta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MACoordinateRegion
    {
        public CLLocationCoordinate2D center;

        public MACoordinateSpan span;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapPoint
    {
        public double x;

        public double y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapSize
    {
        public double width;

        public double height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MAMapRect
    {
        public MAMapPoint origin;

        public MAMapSize size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MATileOverlayPath
    {
        public nint x;

        public nint y;

        public nint z;

        public nfloat contentScaleFactor;
    }

    static class CFunctions
    {
        #region Link Error

        // TODO:MACoordinateBoundsMake
        //// MACoordinateBounds MACoordinateBoundsMake (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MACoordinateBounds MACoordinateBoundsMake(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);

        // TODO:MACoordinateRegionMake
        //// MACoordinateRegion MACoordinateRegionMake (CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MACoordinateRegion MACoordinateRegionMake(CLLocationCoordinate2D centerCoordinate, MACoordinateSpan span);

        //// extern MACoordinateRegion MACoordinateRegionMakeWithDistance (CLLocationCoordinate2D centerCoordinate, CLLocationDistance latitudinalMeters, CLLocationDistance longitudinalMeters);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MACoordinateRegion MACoordinateRegionMakeWithDistance(CLLocationCoordinate2D centerCoordinate, double latitudinalMeters, double longitudinalMeters);

        // TODO:MACoordinateSpanMake
        //// MACoordinateSpan MACoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MACoordinateSpan MACoordinateSpanMake(double latitudeDelta, double longitudeDelta);

        // TODO:MAMapPointEqualToPoint
        //// BOOL MAMapPointEqualToPoint (MAMapPoint point1, MAMapPoint point2);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern bool MAMapPointEqualToPoint(MAMapPoint point1, MAMapPoint point2);

        // TODO:MAMapPointMake
        //// MAMapPoint MAMapPointMake (double x, double y);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MAMapPoint MAMapPointMake(double x, double y);




        // TODO：MAMapSizeMake
        //// MAMapSize MAMapSizeMake (double width, double height);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MAMapSize MAMapSizeMake(double width, double height);

        // MAMapRectMake
        //// MAMapRect MAMapRectMake (double x, double y, double width, double height);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern MAMapRect MAMapRectMake(double x, double y, double width, double height);

        // TODO:MAMapRectGetMinX
        //// double MAMapRectGetMinX (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMinX(MAMapRect rect);

        // MAMapRectGetMinY
        //// double MAMapRectGetMinY (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMinY(MAMapRect rect);

        // TODO:MAMapRectGetMidX
        //// double MAMapRectGetMidX (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMidX(MAMapRect rect);

        // TODO:MAMapRectGetMidY
        //// double MAMapRectGetMidY (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMidY(MAMapRect rect);


        // TODO：MAMapRectGetMaxX
        //// double MAMapRectGetMaxX (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMaxX(MAMapRect rect);

        // TODO:MAMapRectGetMaxY
        //// double MAMapRectGetMaxY (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetMaxY(MAMapRect rect);

        // TODO:MAMapRectGetWidth
        //// double MAMapRectGetWidth (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetWidth(MAMapRect rect);

        // TODO：MAMapRectGetHeight
        //// double MAMapRectGetHeight (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern double MAMapRectGetHeight(MAMapRect rect);

        // TODO:MAMapSizeEqualToSize
        //// BOOL MAMapSizeEqualToSize (MAMapSize size1, MAMapSize size2);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern bool MAMapSizeEqualToSize(MAMapSize size1, MAMapSize size2);

        // TODO:MAMapRectEqualToRect
        //// BOOL MAMapRectEqualToRect (MAMapRect rect1, MAMapRect rect2);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern bool MAMapRectEqualToRect(MAMapRect rect1, MAMapRect rect2);

        // TODO:MAMapRectIsNull
        //// BOOL MAMapRectIsNull (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern bool MAMapRectIsNull(MAMapRect rect);

        // TODO:MAMapRectIsEmpty
        //// BOOL MAMapRectIsEmpty (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern bool MAMapRectIsEmpty(MAMapRect rect);

        // TODO:MAStringFromMapPoint
        //// NSString * MAStringFromMapPoint (MAMapPoint point);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern NSString MAStringFromMapPoint(MAMapPoint point);

        // TODO：MAStringFromMapSize
        //// NSString * MAStringFromMapSize (MAMapSize size);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern NSString MAStringFromMapSize(MAMapSize size);

        // TODO:MAStringFromMapRect
        //// NSString * MAStringFromMapRect (MAMapRect rect);
        //[DllImport("__Internal")]
        ////[Verify(PlatformInvoke)]
        //static extern NSString MAStringFromMapRect(MAMapRect rect); 
        #endregion

        #region MyRegion
        // extern MAMapPoint MAMapPointForCoordinate (CLLocationCoordinate2D coordinate);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapPoint MAMapPointForCoordinate(CLLocationCoordinate2D coordinate);

        // extern CLLocationCoordinate2D MACoordinateForMapPoint (MAMapPoint mapPoint);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern CLLocationCoordinate2D MACoordinateForMapPoint(MAMapPoint mapPoint);

        // extern MACoordinateRegion MACoordinateRegionForMapRect (MAMapRect rect);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MACoordinateRegion MACoordinateRegionForMapRect(MAMapRect rect);

        // extern MAMapRect MAMapRectForCoordinateRegion (MACoordinateRegion region);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectForCoordinateRegion(MACoordinateRegion region);

        // extern CLLocationDistance MAMetersPerMapPointAtLatitude (CLLocationDegrees latitude);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMetersPerMapPointAtLatitude(double latitude);

        // extern double MAMapPointsPerMeterAtLatitude (CLLocationDegrees latitude);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMapPointsPerMeterAtLatitude(double latitude);

        // extern CLLocationDistance MAMetersBetweenMapPoints (MAMapPoint a, MAMapPoint b);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAMetersBetweenMapPoints(MAMapPoint a, MAMapPoint b);

        // extern double MAAreaBetweenCoordinates (CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAAreaBetweenCoordinates(CLLocationCoordinate2D northEast, CLLocationCoordinate2D southWest);

        // extern MAMapRect MAMapRectInset (MAMapRect rect, double dx, double dy);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectInset(MAMapRect rect, double dx, double dy);

        // extern MAMapRect MAMapRectUnion (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapRect MAMapRectUnion(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MAMapSizeContainsSize (MAMapSize size1, MAMapSize size2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapSizeContainsSize(MAMapSize size1, MAMapSize size2);

        // extern BOOL MAMapRectContainsPoint (MAMapRect rect, MAMapPoint point);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectContainsPoint(MAMapRect rect, MAMapPoint point);

        // extern BOOL MAMapRectIntersectsRect (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectIntersectsRect(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MAMapRectContainsRect (MAMapRect rect1, MAMapRect rect2);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MAMapRectContainsRect(MAMapRect rect1, MAMapRect rect2);

        // extern BOOL MACircleContainsPoint (MAMapPoint point, MAMapPoint center, double radius);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MACircleContainsPoint(MAMapPoint point, MAMapPoint center, double radius);

        // extern BOOL MACircleContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern bool MACircleContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D center, double radius);

        // extern BOOL MAPolygonContainsPoint (MAMapPoint point, MAMapPoint *polygon, NSUInteger count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe bool MAPolygonContainsPoint(MAMapPoint point, MAMapPoint* polygon, nuint count);

        // extern BOOL MAPolygonContainsCoordinate (CLLocationCoordinate2D point, CLLocationCoordinate2D *polygon, NSUInteger count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe bool MAPolygonContainsCoordinate(CLLocationCoordinate2D point, CLLocationCoordinate2D* polygon, nuint count);

        // extern MAMapPoint MAGetNearestMapPointFromLine (MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern MAMapPoint MAGetNearestMapPointFromLine(MAMapPoint lineStart, MAMapPoint lineEnd, MAMapPoint point);

        // extern void MAGetTileProjectionFromBounds (MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        //static extern void MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, AMapTileProjectionBlock tileProjection);
        static extern void MAGetTileProjectionFromBounds(MACoordinateBounds bounds, int levelOfDetails, IntPtr tileProjection);


        // extern double MAAreaForPolygon (CLLocationCoordinate2D *coordinates, int count);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern unsafe double MAAreaForPolygon(CLLocationCoordinate2D* coordinates, int count);


        // extern CLLocationCoordinate2D MACoordinateConvert (CLLocationCoordinate2D coordinate, MACoordinateType type) __attribute__((deprecated("已废弃，使用AMapFoundation中关于坐标转换的接口")));
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern CLLocationCoordinate2D MACoordinateConvert(CLLocationCoordinate2D coordinate, MACoordinateType type);

        // extern CLLocationDirection MAGetDirectionFromCoords (CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDirectionFromCoords(CLLocationCoordinate2D fromCoord, CLLocationCoordinate2D toCoord);

        // extern CLLocationDirection MAGetDirectionFromPoints (MAMapPoint fromPoint, MAMapPoint toPoint);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDirectionFromPoints(MAMapPoint fromPoint, MAMapPoint toPoint);

        // extern double MAGetDistanceFromPointToLine (MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd);
        [DllImport("__Internal")]
        //[Verify(PlatformInvoke)]
        static extern double MAGetDistanceFromPointToLine(MAMapPoint point, MAMapPoint lineBegin, MAMapPoint lineEnd); 
        #endregion
    }

    [Native]
    public enum MACoordinateType : ulong
    {
        Baidu = 0,
        MapBar,
        MapABC,
        SoSoMap,
        AliYun,
        Google,
        Gps
    }

    public enum MALineJoinType : uint
    {
        Bevel,
        Miter,
        Round
    }

    public enum MALineCapType : uint
    {
        Butt,
        Square,
        Arrow,
        Round
    }

    [Native]
    public enum MALineDashType : ulong
    {
        None = 0,
        Square,
        Dot
    }

    [Native]
    public enum MAAnnotationViewDragState : ulong
    {
        None = 0,
        Starting,
        Dragging,
        Canceling,
        Ending
    }

    [Native]
    public enum MAMapType : ulong
    {
        Standard = 0,
        Satellite,
        StandardNight,
        Navi,
        Bus
    }

    [Native]
    public enum MAUserTrackingMode : ulong
    {
        None = 0,
        Follow = 1,
        FollowWithHeading = 2
    }

    [Native]
    public enum MATrafficStatus : ulong
    {
        Smooth = 1,
        Slow,
        Jam,
        SeriousJam
    }

    [Native]
    public enum MAOverlayLevel : ulong
    {
        Roads = 0,
        Labels
    }

    [Native]
    public enum MAPinAnnotationColor : ulong
    {
        Red = 0,
        Green,
        Purple
    }



    [Native]
    public enum MAOfflineItemStatus : ulong
    {
        None = 0,
        Cached,
        Installed,
        Expired
    }

    public enum MAOfflineCityStatus : ulong
    {
        None = MAOfflineItemStatus.None,
        Cached = MAOfflineItemStatus.Cached,
        Installed = MAOfflineItemStatus.Installed,
        Expired = MAOfflineItemStatus.Expired
    }

    [Native]
    public enum MAOfflineMapDownloadStatus : ulong
    {
        Waiting = 0,
        Start,
        Progress,
        Completed,
        Cancelled,
        Unzip,
        Finished,
        Error
    }

    [Native]
    public enum MAOfflineMapError : long
    {
        Unknown = -1,
        CannotWriteToTmp = -2,
        CannotOpenZipFile = -3,
        CannotExpand = -4
    }

}


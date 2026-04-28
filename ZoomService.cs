namespace SimpleTextEditor
{
    public class ZoomService
    {
        private const float MAX_ZOOM = 10f;
        private const float MIN_ZOOM = 0.5f;
        private const float BASE_ZOOM = 1f;
        private const float ZOOM_CHANGE_STEP = 0.1f;

        public float Increase(float currentZoom) => currentZoom < MAX_ZOOM 
            ? currentZoom + ZOOM_CHANGE_STEP : currentZoom;
        public float Decrease(float currentZoom) => currentZoom > MIN_ZOOM 
            ? currentZoom - ZOOM_CHANGE_STEP : currentZoom;
        public float Reset() => BASE_ZOOM;
    }
}

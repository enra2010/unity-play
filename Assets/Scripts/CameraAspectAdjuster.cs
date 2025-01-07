using UnityEngine;

public class CameraAspectAdjuster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        float targetAspect = 16.0f / 9.0f; // Dein Zielseitenverhältnis
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera mainCamera = Camera.main;

        if (scaleHeight < 1.0f) {
            Rect rect = mainCamera.rect;

            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;

            mainCamera.rect = rect;
        } else {
            float scaleWidth = 1.0f / scaleHeight;

            Rect rect = mainCamera.rect;

            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;

            mainCamera.rect = rect;
        }
    }
}

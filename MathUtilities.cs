using UnityEngine;

namespace OuterRimStudios.Utilities
{
    public static class MathUtilities
    {
        #region MapValue
        /// <summary>Converts the value passed in to a value within a 0 to 1 range.</summary>
        /// <param name="min">Low end of the range that the value can be before converting to a 0-1 range.</param>
        /// <param name="max">High end of the range that the value can be before converting to a 0-1 range.</param>
        /// <param name="value">Value to be converted to a 0-1 range</param>
        /// <returns>Returns input value converted to be a value between 0 and 1 as a float.</returns>
        public static float MapValue01(float min, float max, float value)
        {
            return min + (max - min) * ((value - 0) / (1 - 0));
        }

        /// <summary>Converts the value passed in to a value within an entered range.</summary>
        /// <param name="range1Min">Low end of the range that the value will be converted to fit within.</param>
        /// <param name="range1Max">High end of the range that the value will be converted to fit within.</param>
        /// <param name="range2Min">Low end of the range that the value can be before converting to fit within the target range.</param>
        /// <param name="range2Max">High end of the range that the value can be before converting to fit within the target range.</param>
        /// <param name="value"></param>
        /// <returns>Returns input value converted to be a value between entered range as a float.</returns>
        public static float MapValue(float range1Min, float range1Max, float range2Min, float range2Max, float value)
        {
            return range2Min + (range2Max - range2Min) * ((value - range1Min) / (range1Max - range1Min));
        }
        #endregion

        #region Clamp
        /// <summary>Clamps all axes of the entered Vector3 between the negative and positive of the entered clamp value.</summary>
        /// <param name="vector"></param>
        /// <param name="clampValue"></param>
        /// <returns>Returns the clamped Vector3.</returns>
        public static Vector3 Clamp(Vector3 vector, float clampValue)
        {
            return new Vector3(Mathf.Clamp(vector.x, -clampValue, clampValue), Mathf.Clamp(vector.y, -clampValue, clampValue), Mathf.Clamp(vector.z, -clampValue, clampValue));
        }

        /// <summary>Clamps all axes of the entered Vector3 between the entered min clamp value and the entered max clamp value.</summary>
        /// <param name="vector"></param>
        /// <param name="minClampValue"></param>
        /// <param name="maxClampValue"></param>
        /// <returns>Returns the clamped Vector3.</returns>
        public static Vector3 Clamp(Vector3 vector, float minClampValue, float maxClampValue)
        {
            return new Vector3(Mathf.Clamp(vector.x, minClampValue, maxClampValue), Mathf.Clamp(vector.y, minClampValue, maxClampValue), Mathf.Clamp(vector.z, minClampValue, maxClampValue));
        }
        #endregion

        #region CheckDistance
        /// <summary>Calculates the distance between two Vector3 points.</summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns>Distance between two points as a float</returns>
        public static float CheckDistance(Vector3 point1, Vector3 point2)
        {
            Vector3 heading;
            float distance;
            Vector3 direction;
            float distanceSquared;

            heading.x = point1.x - point2.x;
            heading.y = point1.y - point2.y;
            heading.z = point1.z - point2.z;

            distanceSquared = heading.x * heading.x + heading.y * heading.y + heading.z * heading.z;
            distance = Mathf.Sqrt(distanceSquared);

            direction.x = heading.x / distance;
            direction.y = heading.y / distance;
            direction.z = heading.z / distance;
            return distance;
        }

        /// <summary>Calculates the distance between two Vector2 points.</summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns>Distance between two points as a float</returns>
        public static float CheckDistance(Vector2 point1, Vector2 point2)
        {
            Vector2 heading;
            float distance;
            Vector2 direction;
            float distanceSquared;

            heading.x = point1.x - point2.x;
            heading.y = point1.y - point2.y;

            distanceSquared = heading.x * heading.x + heading.y * heading.y;
            distance = Mathf.Sqrt(distanceSquared);

            direction.x = heading.x / distance;
            direction.y = heading.y / distance;
            return distance;
        }
        #endregion
    }
}
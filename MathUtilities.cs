//DOCUMENTATION:    https://github.com/OuterRimStudios/Utilities/wiki/Math-Utilities

using UnityEngine;

namespace OuterRimStudios.Utilities
{
    public static class MathUtilities
    {
        #region MapValue
        /// <summary>Maps a value that exists between a range to be within a 0 to 1 range.</summary>
        /// <param name="currentRangeMin">The minimum value of the range that the value currently exists.</param>
        /// <param name="currentRangeMax">The maximum value of the range that the value currently exists.</param>
        /// <param name="value">The value to be mapped within the new range.</param>
        /// <returns>Returns input value converted to a value within a 0 to 1 range.</returns>
        public static float MapValue01(float currentRangeMin, float currentRangeMax, float value)
        {
            return currentRangeMin + (currentRangeMax - currentRangeMin) * ((value - 0) / (1 - 0));
        }

        /// <summary>Maps a value that exists between a range to be within a new range.</summary>
        /// <param name="newRangeMin">The minimum value of the range within which the value will be mapped.</param>
        /// <param name="newRangeMax">The maximum value of the range within which the value will be mapped.</param>
        /// <param name="currentRangeMin">The minimum value of the range that the value currently exists.</param>
        /// <param name="currentRangeMax">The maximum value of the range that the value currently exists.</param>
        /// <param name="value">The value to be mapped within the new range.</param>
        /// <returns>Returns input value converted to a value within new range.</returns>
        public static float MapValue(float newRangeMin, float newRangeMax, float currentRangeMin, float currentRangeMax, float value)
        {
            return currentRangeMin + (currentRangeMax - currentRangeMin) * ((value - newRangeMin) / (newRangeMax - newRangeMin));
        }
        #endregion

        #region Clamp
        /// <summary>Clamps all axes of the entered Vector3 between the negative and positive of the entered clamp value.</summary>
        /// <param name="vector">The Vector3 to be clamped.</param>
        /// <param name="clampValue">The value at which the Vector3 will be clamped.</param>
        /// <returns>Returns the Vector3 after being clamped within the clamp range.</returns>
        public static Vector3 Clamp(Vector3 vector, float clampValue)
        {
            return new Vector3(Mathf.Clamp(vector.x, -clampValue, clampValue), Mathf.Clamp(vector.y, -clampValue, clampValue), Mathf.Clamp(vector.z, -clampValue, clampValue));
        }

        /// <summary>Clamps all axes of the entered Vector3 between the minClampValue and the maxClampValue.</summary>
        /// <param name="vector">The Vector3 to be clamped.</param>
        /// <param name="minClampValue">The minimum value at which the Vector3 will be clamped.</param>
        /// <param name="maxClampValue">The maximum value at which the Vector3 will be clamped.</param>
        /// <returns>Returns the Vector3 after being clamped between the minClampValue and maxClampValue.</returns>
        public static Vector3 Clamp(Vector3 vector, float minClampValue, float maxClampValue)
        {
            return new Vector3(Mathf.Clamp(vector.x, minClampValue, maxClampValue), Mathf.Clamp(vector.y, minClampValue, maxClampValue), Mathf.Clamp(vector.z, minClampValue, maxClampValue));
        }
        #endregion

        #region CheckDistance
        /// <summary>Calculates the distance between two Vector3 points.</summary>
        /// <param name="point1">The first point of the distance calculation.</param>
        /// <param name="point2"> The second point of the distance calculation.</param>
        /// <returns>Return the distance between the two points.</returns>
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
        /// <param name="point1">The first point of the distance calculation.</param>
        /// <param name="point2">The second point of the distance calculation.</param>
        /// <returns>Return the distance between the two points.</returns>
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
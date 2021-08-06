using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text;

namespace Platform
{
    internal partial class PInvoke
    {
        #region Invoke  and Enums
        /// <summary>
        /// to find whether you are running on a Smartphone or a Pocket PC
        /// </summary>
        /// <param name="uiAction"></param>
        /// <param name="uiParam"></param>
        /// <param name="pvParam"></param>
        /// <param name="fWinIni"></param>
        /// <returns></returns>
        [DllImport("Coredll.dll", EntryPoint = "SystemParametersInfoW", CharSet = CharSet.Unicode)]
        static extern int SystemParametersInfo4Strings(uint uiAction, uint uiParam, StringBuilder pvParam, uint fWinIni);
        

        public enum SystemParametersInfoActions : uint
        {
            SPI_GETPLATFORMTYPE = 257, // this is used elsewhere for Smartphone/PocketPC detection

        }
        #endregion

        /// <summary>
        /// Get Platform Type: Pocket Pc or Windows CE
        /// </summary>
        /// <returns></returns>
        public static string GetPlatformType()
        {
            StringBuilder platformType = new StringBuilder(50);
            if (SystemParametersInfo4Strings((uint)SystemParametersInfoActions.SPI_GETPLATFORMTYPE,
                (uint)platformType.Capacity, platformType, 0) == 0)
                throw new Exception("Error getting platform type.");
            return platformType.ToString();
        }
    }

    /// <summary>
    /// Platform Detections methods
    /// </summary>
    internal partial class PlatformDetection
    {
        public static bool IsSmartphone()
        {
            return PInvoke.GetPlatformType() == "SmartPhone";
        }
        public static bool IsPocketPC()
        {
            return PInvoke.GetPlatformType() == "PocketPC";
        }
        public static bool IsWINCE()
        {
            return PInvoke.GetPlatformType() == "CEBase";
        }
    }
    

}
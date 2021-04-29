using Microsoft.Win32;

namespace VNCConfigAssistant
{
    internal static class RegistryManagement
    {
        private static readonly string regkeypath = "SOFTWARE\\RealVNC\\vncserver";

        /// <summary>
        /// Retrieves the current value for a specified String value in the Registry Key for VNC Server
        /// </summary>
        /// <param name="valuename">The name of the String to retrieve</param>
        /// <returns>The value of the String</returns>
        public static string GetRegistryValue(string valuename)
        {
            RegistryKey regkey = Registry.LocalMachine.OpenSubKey(regkeypath, false);
            string value = "";
            try { value = regkey.GetValue(valuename).ToString(); regkey.Close(); }
            catch { SetRegistryValue(valuename, "KEYERROR"); }
            return value;
        }

        /// <summary>
        /// Sets the value for a specified String value in the Registry Key for VNC Server
        /// </summary>
        /// <param name="valuename">The name of the String to set</param>
        /// <param name="value">The value to set</param>
        public static void SetRegistryValue(string valuename, string value)
        {
            RegistryKey regkey = Registry.LocalMachine.CreateSubKey(regkeypath, true);
            try { regkey.SetValue(valuename, value, RegistryValueKind.String); }
            catch { }
            regkey.Close();
        }
    }
}


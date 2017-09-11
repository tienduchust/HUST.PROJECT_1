using Newtonsoft.Json;
using Hust.Models.Share;
using System;
using System.Configuration;
using System.IO;

namespace Hust.Common.Core
{
    /// <summary>
    /// Utilities
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Object To Json
        /// </summary>
        /// <param name="data">data</param>
        /// <returns></returns>
        public static string ObjectToJson(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// Json To Object
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <param name="dataJson"> Data Json</param>
        /// <returns></returns>
        public static T JsonToObject<T>(string dataJson)
        {
            return JsonConvert.DeserializeObject<T>(dataJson);
        }
        /// <summary>
        /// Get App Setting
        /// </summary>
        /// <param name="appSettingKey">AppSetting Key</param>
        /// <returns></returns>
        public static string GetAppSetting(string appSettingKey)
        {
            return ConfigurationManager.AppSettings[appSettingKey];
        }

        /// <summary>
        /// Get Here Link
        /// </summary>
        /// <param name="title">title link</param>
        /// <param name="link">link</param>
        /// <returns></returns>
        public static string GetHereLink(string title, string link)
        {
            return string.Format("<a href='{0}'>{1}</a>", string.Concat(GetAppSetting(Constants.AppSetting.LINK_SITE), "/", link), title);
        }

        /// <summary>
        /// ToBase64String
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToBase64String(byte[] data)
        {
            try
            {
                return Convert.ToBase64String(data);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Stream To Byte
        /// </summary>
        /// <param name="stream">Stream Input</param>
        /// <returns></returns>
        public static byte[] StreamToByte(Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

        /// <summary>
        /// Get Extension
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetExtension(string fileName)
        {
            try
            {
                fileName = string.IsNullOrEmpty(fileName) ? string.Empty : fileName;
                return Path.GetExtension(fileName).Replace(".", string.Empty);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
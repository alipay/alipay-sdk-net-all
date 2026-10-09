using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleToken Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleToken : AopObject
    {
        /// <summary>
        /// 令牌有效时间戳
        /// </summary>
        [XmlElement("expires_in_timestamp")]
        public string ExpiresInTimestamp { get; set; }

        /// <summary>
        /// 刷新令牌有效时间戳
        /// </summary>
        [XmlElement("refresh_expires_in_timestamp")]
        public string RefreshExpiresInTimestamp { get; set; }

        /// <summary>
        /// 车企访问token
        /// </summary>
        [XmlElement("vehicle_access_token")]
        public string VehicleAccessToken { get; set; }

        /// <summary>
        /// 车企刷新token
        /// </summary>
        [XmlElement("vehicle_refresh_token")]
        public string VehicleRefreshToken { get; set; }
    }
}

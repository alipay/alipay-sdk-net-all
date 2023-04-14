using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosQrcodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosQrcodeSyncModel : AopObject
    {
        /// <summary>
        /// 需要同步的桌台与二维码信息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("qrcode_entity")]
        public List<QrcodeEntity> List { get; set; }
    }
}

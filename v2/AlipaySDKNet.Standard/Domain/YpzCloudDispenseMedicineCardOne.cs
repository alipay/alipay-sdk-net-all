using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzCloudDispenseMedicineCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzCloudDispenseMedicineCardOne : AopObject
    {
        /// <summary>
        /// 主按钮跳转地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 卡片状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvestorMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvestorMaterialInfo : AopObject
    {
        /// <summary>
        /// 材料文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 材料文件链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 用户材料类型 INVEST_EXPERIENCE——投资经历 INCOME_CERTIFICATE——收入证明 FIN_ASSET_CERTIFICATE——金融资产证明
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}

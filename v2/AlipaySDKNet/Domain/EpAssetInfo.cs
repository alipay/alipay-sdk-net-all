using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAssetInfo : AopObject
    {
        /// <summary>
        /// 企业资产类型： OP_CERTIFICATE(经营资质证照), OP_PATENT(经营专利)
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// JSON数据列表，根据asset_type存放相应的数据,其中专利的单项结构是 { "patentName": "xx治疗xx的用途", "patentType": "发明公告", "applicationDay": "2003-09-24 00:00:00", "publishNo": "CN2525680Y"}，资质的单项结构是 { "certificateType": "科技型中小企业名单", "certificateNo": "2022110105A0007648"}
        /// </summary>
        [XmlElement("contents")]
        public string Contents { get; set; }
    }
}

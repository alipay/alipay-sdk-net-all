using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMemberHealthdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMemberHealthdataQueryModel : AopObject
    {
        /// <summary>
        /// {"fieldDesc":"HEALTH_CARD(\"C\", \"默认toC渠道卡\", \"健康卡\"),\n    OPPO(\"OPPO\", \"OPPO渠道卡\", \"OPPO\"),\n    AQ(\"AQ\", \"AQ渠道卡\", \"阿福\"),\n    XIAOMI(\"XIAOMI\", \"小米渠道卡\", \"小米\"),\n    ANT(\"ANT\", \"员福渠道卡\", \"员福\"),\n    MEISHI(\"MEI_SHI\",\"美世渠道卡\", \"美世\"),\n    HONOR(\"HONOR\", \"荣耀渠道卡\", \"荣耀\"),\n    ANT_COMMERCIAL(\"ANT_COMMERCIAL\", \"员福商业化渠道卡\", \"员福商业化渠道\"),","fieldName":"channel","fieldZhName":"会员渠道"}
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 要获取的数据
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}

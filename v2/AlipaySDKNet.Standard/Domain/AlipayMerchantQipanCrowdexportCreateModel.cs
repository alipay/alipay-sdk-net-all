using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdexportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdexportCreateModel : AopObject
    {
        /// <summary>
        /// 棋盘侧定义的人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 导出渠道类型
        /// </summary>
        [XmlElement("export_channel_type")]
        public string ExportChannelType { get; set; }

        /// <summary>
        /// 外部业务号，用于幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

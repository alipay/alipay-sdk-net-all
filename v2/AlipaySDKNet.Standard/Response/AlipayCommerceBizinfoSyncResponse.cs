using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceBizinfoSyncResponse.
    /// </summary>
    public class AlipayCommerceBizinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 商户侧资讯id
        /// </summary>
        [XmlElement("biz_info_id")]
        public string BizInfoId { get; set; }

        /// <summary>
        /// 主体单元id
        /// </summary>
        [XmlElement("biz_unit_id")]
        public string BizUnitId { get; set; }

        /// <summary>
        /// 资讯id
        /// </summary>
        [XmlElement("info_id")]
        public string InfoId { get; set; }

        /// <summary>
        /// 安全审核状态
        /// </summary>
        [XmlElement("sec_status")]
        public string SecStatus { get; set; }
    }
}

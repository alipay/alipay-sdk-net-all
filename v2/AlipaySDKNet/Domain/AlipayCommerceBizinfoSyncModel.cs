using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceBizinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceBizinfoSyncModel : AopObject
    {
        /// <summary>
        /// 商户标识，由支付宝分配
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 资讯唯一标识
        /// </summary>
        [XmlElement("biz_info_id")]
        public string BizInfoId { get; set; }

        /// <summary>
        /// 资讯的业务时间，如房产交易资讯的交易时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 主体单元信息，如社区房价咨询填写社区信息
        /// </summary>
        [XmlElement("biz_unit_info")]
        public BizUnit BizUnitInfo { get; set; }

        /// <summary>
        /// 房产交易信息
        /// </summary>
        [XmlElement("house_biz_info")]
        public HouseBizInfo HouseBizInfo { get; set; }

        /// <summary>
        /// 资讯类型
        /// </summary>
        [XmlElement("info_type")]
        public string InfoType { get; set; }
    }
}

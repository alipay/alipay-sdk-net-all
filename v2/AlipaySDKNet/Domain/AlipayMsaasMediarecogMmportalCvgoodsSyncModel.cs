using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalCvgoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalCvgoodsSyncModel : AopObject
    {
        /// <summary>
        /// 上新申请ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 信息审核日期，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品属性信息
        /// </summary>
        [XmlElement("goods_info")]
        public CVGoodsInfo GoodsInfo { get; set; }

        /// <summary>
        /// 商品识别类型，枚举值
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商户名称，填PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }
    }
}

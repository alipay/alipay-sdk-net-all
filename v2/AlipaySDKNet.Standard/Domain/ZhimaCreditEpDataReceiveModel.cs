using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDataReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDataReceiveModel : AopObject
    {
        /// <summary>
        /// 用于接收商户上传的企业相关数据，例如招投标报告的部分附件信息
        /// </summary>
        [XmlArray("data_info")]
        [XmlArrayItem("ep_report_data_info")]
        public List<EpReportDataInfo> DataInfo { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称，对于招投标订单，传入投标的企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 企信返回的业务订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单所属业务类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}

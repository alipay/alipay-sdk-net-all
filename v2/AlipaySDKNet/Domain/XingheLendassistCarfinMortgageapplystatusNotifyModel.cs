using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinMortgageapplystatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinMortgageapplystatusNotifyModel : AopObject
    {
        /// <summary>
        /// 交科所的抵押订单序号
        /// </summary>
        [XmlElement("jksxh")]
        public string Jksxh { get; set; }

        /// <summary>
        /// 星河侧唯一抵押订单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 机构侧唯一抵押订单号
        /// </summary>
        [XmlElement("out_mortgage_no")]
        public string OutMortgageNo { get; set; }

        /// <summary>
        /// 提交抵押预受理需要的信息
        /// </summary>
        [XmlElement("pre_mortgage_info")]
        public CarfinPreMortgageInfo PreMortgageInfo { get; set; }

        /// <summary>
        /// 代理人不合法的文件列表
        /// </summary>
        [XmlArray("proxy_invalid_file_list")]
        [XmlArrayItem("string")]
        public List<string> ProxyInvalidFileList { get; set; }

        /// <summary>
        /// 绿本收件人地址
        /// </summary>
        [XmlElement("receiver_info")]
        public XhExpressPostInfo ReceiverInfo { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 客户抵押状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 需要补充的协议文件
        /// </summary>
        [XmlArray("supple_agreement_list")]
        [XmlArrayItem("string")]
        public List<string> SuppleAgreementList { get; set; }

        /// <summary>
        /// 需要补充的文件列表
        /// </summary>
        [XmlArray("supple_file_list")]
        [XmlArrayItem("string")]
        public List<string> SuppleFileList { get; set; }
    }
}

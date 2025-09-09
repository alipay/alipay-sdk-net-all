using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistSrcfterdeliveryAccessApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistSrcfterdeliveryAccessApproveModel : AopObject
    {
        /// <summary>
        /// 是否代收标识，NOT_COLLECTION-非代收 、COLLECTION-代收
        /// </summary>
        [XmlElement("collection_flag")]
        public string CollectionFlag { get; set; }

        /// <summary>
        /// 设备代收人身份证号
        /// </summary>
        [XmlElement("collector_id_card")]
        public string CollectorIdCard { get; set; }

        /// <summary>
        /// 设备代收人的姓名
        /// </summary>
        [XmlElement("collector_name")]
        public string CollectorName { get; set; }

        /// <summary>
        /// 设备代收人手机号
        /// </summary>
        [XmlElement("collector_phone")]
        public string CollectorPhone { get; set; }

        /// <summary>
        /// 政企员工团购分期授信初审的申请单号
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 平台为接入客户分配
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 唯一标识政企员工团购分期终端交付请求
        /// </summary>
        [XmlElement("out_bsn_no")]
        public string OutBsnNo { get; set; }

        /// <summary>
        /// 业务所属产品，平台为业务分配
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 文件上传接口上传收货确认书成功后返回的文件id
        /// </summary>
        [XmlElement("receipt_con_file_id")]
        public string ReceiptConFileId { get; set; }

        /// <summary>
        /// 政企员工的身份证号
        /// </summary>
        [XmlElement("user_id_card")]
        public string UserIdCard { get; set; }

        /// <summary>
        /// 政企员工的姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 政企员工名下手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}

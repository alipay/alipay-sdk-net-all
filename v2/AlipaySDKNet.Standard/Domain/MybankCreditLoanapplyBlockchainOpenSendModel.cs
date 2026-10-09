using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyBlockchainOpenSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyBlockchainOpenSendModel : AopObject
    {
        /// <summary>
        /// 业务类型,NOTICE_SEND_EVENT,机构侧通知发送 ,SDK枚举获取 业务类型,UPLOAD_FILE_FOR_CHAIN_EVENT,文件上链请求,SDK枚举获取 业务类
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 业务字段,暂时不需要，后续可能留不同机构差异性扩展用
        /// </summary>
        [XmlElement("data_object")]
        public string DataObject { get; set; }
    }
}

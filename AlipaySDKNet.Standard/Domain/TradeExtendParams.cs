using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class TradeExtendParams : AopObject
    {
        /// <summary>
        /// 渠道标识
        /// </summary>
        [XmlElement("chinfo")]
        public string Chinfo { get; set; }

        /// <summary>
        /// 医保补充计算金额(在insurance_subsidy_mode不为空时该字段也不能为空）
        /// </summary>
        [XmlElement("insurance_subsidy_amount")]
        public string InsuranceSubsidyAmount { get; set; }

        /// <summary>
        /// 医保补充计算方式
        /// </summary>
        [XmlElement("insurance_subsidy_mode")]
        public string InsuranceSubsidyMode { get; set; }

        /// <summary>
        /// 医保补充计算说明
        /// </summary>
        [XmlElement("insurance_subsidy_type")]
        public string InsuranceSubsidyType { get; set; }

        /// <summary>
        /// 用户卡信息中机构内卡号,用户授权成功时返回
        /// </summary>
        [XmlElement("medical_card_id")]
        public string MedicalCardId { get; set; }

        /// <summary>
        /// 用户卡信息中机构编码,用户授权成功时返回
        /// </summary>
        [XmlElement("medical_ins_card_id")]
        public string MedicalInsCardId { get; set; }

        /// <summary>
        /// 医保数据结构体,各地透传参数详见"医保透传参数说明"
        /// </summary>
        [XmlElement("request_content")]
        public string RequestContent { get; set; }

        /// <summary>
        /// 使用场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 系统商编号，该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}

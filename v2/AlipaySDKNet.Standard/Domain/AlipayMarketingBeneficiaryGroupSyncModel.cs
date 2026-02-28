using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBeneficiaryGroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBeneficiaryGroupSyncModel : AopObject
    {
        /// <summary>
        /// 为用户申请资格还是退回资格标识。 申领资格:APPLY 退回资格:EXPIRE
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 支持三种类型 1.用户手机号，固定11位 2.用户邮箱 3.支付宝账号
        /// </summary>
        [XmlElement("bind_contact")]
        public string BindContact { get; set; }

        /// <summary>
        /// 服务商信息,可填自己的公司主体
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 传入的账号类型，支持三种: 手机号、邮箱、支付宝账号
        /// </summary>
        [XmlElement("login_type")]
        public string LoginType { get; set; }

        /// <summary>
        /// 业务幂等字段,用户标识服务商是否同一笔请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝分配的场景编码，用于识别活动场景信息,支付宝提供给服务商
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 数据源写入标识,服务方提供
        /// </summary>
        [XmlElement("turing_tag")]
        public string TuringTag { get; set; }
    }
}

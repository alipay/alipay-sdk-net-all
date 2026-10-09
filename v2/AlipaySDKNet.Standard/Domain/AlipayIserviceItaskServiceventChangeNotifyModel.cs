using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskServiceventChangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskServiceventChangeNotifyModel : AopObject
    {
        /// <summary>
        /// 用户的标识数据，可以是手机号码、身份证号等
        /// </summary>
        [XmlElement("customer_identity")]
        public string CustomerIdentity { get; set; }

        /// <summary>
        /// 用户标识类型，如手机号，身份证号
        /// </summary>
        [XmlElement("customer_identity_type")]
        public string CustomerIdentityType { get; set; }

        /// <summary>
        /// 服务备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 机构编号
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 外部机构侧的服务动作，如，升级专家，转接、完结等
        /// </summary>
        [XmlElement("out_action_type")]
        public string OutActionType { get; set; }

        /// <summary>
        /// 站在机构视角，外部的服务ID（蚂蚁的服务ID）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部服务评价结果
        /// </summary>
        [XmlElement("out_service_assess")]
        public string OutServiceAssess { get; set; }

        /// <summary>
        /// 外部机构侧服务结束时间；服务结束状态时，不可空
        /// </summary>
        [XmlElement("out_service_end_time")]
        public string OutServiceEndTime { get; set; }

        /// <summary>
        /// 外部机构侧，表示一通服务的唯一ID
        /// </summary>
        [XmlElement("out_service_record_id")]
        public string OutServiceRecordId { get; set; }

        /// <summary>
        /// 外部机构服务开始时间；服务开始状态时必填
        /// </summary>
        [XmlElement("out_service_start_time")]
        public string OutServiceStartTime { get; set; }

        /// <summary>
        /// 外部机构侧服务状态
        /// </summary>
        [XmlElement("out_service_state")]
        public string OutServiceState { get; set; }

        /// <summary>
        /// 服务类型，如：人工热线，人工在线
        /// </summary>
        [XmlElement("out_service_type")]
        public string OutServiceType { get; set; }

        /// <summary>
        /// 用于描述这个服务事件的摘要信息，如：用户反馈某笔交易未到账
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 服务转接来源
        /// </summary>
        [XmlElement("transfer_source")]
        public string TransferSource { get; set; }
    }
}

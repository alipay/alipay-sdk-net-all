using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalYpzEventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalYpzEventSendModel : AopObject
    {
        /// <summary>
        /// 服务端根据功能需要传过来
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 业务类型： 预约记录:YYJL 挂号记录(预约+当日):GHJL 门诊就诊记录:MZJZJL 停诊通知:TZTZ
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 用来判断业务执行哪个流程 数据上传:UPLOAD 数据更新:UPDATE
        /// </summary>
        [XmlElement("op_code")]
        public string OpCode { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 区域平台归属单位的18位统一社会信用代码。（单家医疗机构接入时不可传值），通过区域平台接入方式请求时必传。
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskEvaluationQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RiskEvaluationQueryRequest : AopObject
    {
        /// <summary>
        /// 参数名：业务请求参数 是否唯一：不唯一 应用场景：计算风险时所需要的风险详情参数（根据不同业务而不同） 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("biz_detail")]
        public string BizDetail { get; set; }

        /// <summary>
        /// 参数名：业务控制对象编码 是否唯一：唯一 应用场景：用于描述业务单据号用于标识一个业务对象信息选填 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 参数名：业务控制对象编码 是否唯一：不唯一 应用场景：用于风险控制系统识别调用方的业务 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("control_obj_code")]
        public string ControlObjCode { get; set; }

        /// <summary>
        /// 参数名：操作人工号 是否唯一：不唯一 应用场景：当前业务的操作人的蚂蚁工号 枚举值：无 如何获取：不相关 特务说明：无
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}

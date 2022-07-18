using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放计划主键 id
        /// </summary>
        [XmlElement("put_plan_id")]
        public long PutPlanId { get; set; }
    }
}

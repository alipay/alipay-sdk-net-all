using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceDatapropertyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceDatapropertyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 描述针对datachannel需要执行的操作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务请求入参，云上系统直接转发给域内用来拼接参数
        /// </summary>
        [XmlElement("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 描述业务调用方名字基础信息
        /// </summary>
        [XmlElement("base")]
        public string Base { get; set; }

        /// <summary>
        /// 描述调用的具体数据渠道名
        /// </summary>
        [XmlElement("data_channel")]
        public string DataChannel { get; set; }

        /// <summary>
        /// 业务访问的tag名
        /// </summary>
        [XmlElement("visit_ac")]
        public string VisitAc { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("visit_biz_line")]
        public string VisitBizLine { get; set; }

        /// <summary>
        /// bu名称
        /// </summary>
        [XmlElement("visit_bu")]
        public string VisitBu { get; set; }
    }
}

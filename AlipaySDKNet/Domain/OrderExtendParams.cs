using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtendParams : AopObject
    {
        /// <summary>
        /// 外部场景端业务订单
        /// </summary>
        [XmlElement("out_scene_biz_no")]
        public string OutSceneBizNo { get; set; }
    }
}

using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyMfvSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyMfvSubmitModel : AopObject
    {
        /// <summary>
        /// execute_type标识提交内容，如果是预执行则填写preExecute，如果是执行则填写doExecute
        /// </summary>
        [XmlElement("execute_type")]
        public string ExecuteType { get; set; }

        /// <summary>
        /// out_biz_type和out_biz_order_no在同租户下控制幂等，需要找接口提供方分配
        /// </summary>
        [XmlElement("out_biz_order_no")]
        public string OutBizOrderNo { get; set; }

        /// <summary>
        /// out_biz_type和out_biz_order_no在同租户下控制幂等，需要找接口提供方分配
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// params是核验参数，提交的是json格式，具体的key，需要看接入的场景scene_id，和接口的提供方分配
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// scene_id是场景id，由接口提供方进行分配
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}

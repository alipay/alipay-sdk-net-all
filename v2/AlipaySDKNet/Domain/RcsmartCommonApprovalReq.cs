using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcsmartCommonApprovalReq Data Structure.
    /// </summary>
    [Serializable]
    public class RcsmartCommonApprovalReq : AopObject
    {
        /// <summary>
        /// 业务ID，一个业务bizId代表当前业务，可以包含多个场景，与scene_code之间为一对多的关系。 @结月分配
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 预留参数，K-V格式
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 请求的父级工单ID
        /// </summary>
        [XmlElement("parent_request_id")]
        public string ParentRequestId { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景素材信息。Map的key为场景编码，value为素材列表信息
        /// </summary>
        [XmlArray("scene_content_data_list")]
        [XmlArrayItem("rcsmart_scene_content_data")]
        public List<RcsmartSceneContentData> SceneContentDataList { get; set; }
    }
}

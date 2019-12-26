using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationContentQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationContentQueryResponse : AopResponse
    {
        /// <summary>
        /// 内容信息列表 , json 格式 , 每一个展台对应一个 内容列表 .  每一个内容信息模型对应 : ContentInfoModel
        /// </summary>
        [XmlArray("content_infos")]
        [XmlArrayItem("booth_content_info_model")]
        public List<BoothContentInfoModel> ContentInfos { get; set; }

        /// <summary>
        /// 非单条内容信息维度的扩展数据
        /// </summary>
        [XmlElement("ext_data")]
        public OperationExtDataModel ExtData { get; set; }
    }
}

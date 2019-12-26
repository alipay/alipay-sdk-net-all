using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialQueryResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialQueryResponse : AopResponse
    {
        /// <summary>
        /// 配料对象
        /// </summary>
        [XmlArray("material_entity_list")]
        [XmlArrayItem("material_entity")]
        public List<MaterialEntity> MaterialEntityList { get; set; }
    }
}

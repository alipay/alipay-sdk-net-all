using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKdsInfoModifyModel : AopObject
    {
        /// <summary>
        /// kds配置详情
        /// </summary>
        [XmlArray("kds_info_model_list")]
        [XmlArrayItem("kds_info_model")]
        public List<KdsInfoModel> KdsInfoModelList { get; set; }
    }
}

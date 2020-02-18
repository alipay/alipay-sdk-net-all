using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentShopsQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentShopsQueryResponse : AopResponse
    {
        /// <summary>
        /// 根据部门id查询返回的门店模型列表
        /// </summary>
        [XmlArray("city_shop_models")]
        [XmlArrayItem("city_shop_model")]
        public List<CityShopModel> CityShopModels { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }
    }
}

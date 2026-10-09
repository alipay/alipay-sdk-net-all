using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasProductCommonQueryResponse.
    /// </summary>
    public class AntProdpaasProductCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 产品基本信息
        /// </summary>
        [XmlElement("prod_base")]
        public ProductBaseVO ProdBase { get; set; }

        /// <summary>
        /// 产品条件信息。值为json结构,嵌套结构。normal代表普通条件，其他代表息费等复杂条件，key为条件别名，value为条件值.
        /// </summary>
        [XmlElement("prod_condition")]
        public string ProdCondition { get; set; }

        /// <summary>
        /// 产品参与者关系列表
        /// </summary>
        [XmlArray("prod_ip_list")]
        [XmlArrayItem("prod_i_p_relation_v_o")]
        public List<ProdIPRelationVO> ProdIpList { get; set; }

        /// <summary>
        /// 产品区域关联信息列表
        /// </summary>
        [XmlArray("prod_lo_list")]
        [XmlArrayItem("prod_l_o_relation_v_o")]
        public List<ProdLORelationVO> ProdLoList { get; set; }

        /// <summary>
        /// 产品外标关系列表
        /// </summary>
        [XmlArray("prod_mark_list")]
        [XmlArrayItem("prod_mark_relation_v_o")]
        public List<ProdMarkRelationVO> ProdMarkList { get; set; }

        /// <summary>
        /// 产品间关系列表
        /// </summary>
        [XmlArray("prod_rel_list")]
        [XmlArrayItem("prod_relation_v_o")]
        public List<ProdRelationVO> ProdRelList { get; set; }
    }
}

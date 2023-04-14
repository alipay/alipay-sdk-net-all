using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvAuthSceneInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvAuthSceneInfo : AopObject
    {
        /// <summary>
        /// 运营场景编码 OPERATION_POINTS：管理运营积分 SHOP_MANAGE：管理门店信息 MINI_APP_OPER：运营支付宝小程序 PROMOTION_MANAGE：运营营销活动
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 运营场景下的权限编码，多个权限编码以,隔开 1、管理门店信息：SHOP_MANAGE；基础权限（升级）：SHOP_MANAGE_BASE 2、运营营销活动：PROMOTION_MANAGE ；基础权限（升级）：PROMOTION_MANAGE_BASE 3、运营支付宝小程序：MINI_APP_OPER；基础权限（升级）：MINI_APP_OPER_BASE 4、管理运营积分：OPERATION_POINTS；基础权限（升级）：OPERATION_POINTS_BASE
        /// </summary>
        [XmlElement("scene_permissions")]
        public string ScenePermissions { get; set; }
    }
}

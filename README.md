# unity3d-AssetMarker
#功能#
·资源导入时，根据所在目录是否受AssetMarker约束而自动设置
·手动设置所有受AssetMarker约束的资源

#参数
·bundleName：AssetBundleName命名规则，例：uis/views/{firstdir}
    可选参数：
    ·fulldir：与AssetMarker配置文件的相对路径
    ·firstdir：与AssetMarker配置文件的相对路径的第一个目录命名。
    ·filename：使用asset的名字命名
·include/exclude：资源筛选规则

#TODO：
·支持嵌套
·异常检测和处理
    ·重复设置
    ·不合理的命名自动设置为__foundation
·检测资源是否有冗余
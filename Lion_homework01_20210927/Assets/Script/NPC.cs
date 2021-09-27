using UnityEngine;

/// <summary>NPC 定義 NPC 方法
/// </summary>
public class NPC : MonoBehaviour
{
/// 對話功能
///<param name="dialogue"> NPC 要說的對話內容</param>>
private void Dialogue(string dialogue)
{
        
}
    ///更新任務
    ///<param name="propMission">任務道具數量</param>
    private int UpdateMisiion(int propMission = 1)
    {
        return 0;
    }

    ///完成任務
    ///<param name="indexMission">任務編號</param>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }

    ///開啟商店
    public bool OpenShop()
    {
        return true;
    }

    ///購買道具
    ///<param name="price">道具價格</param>
    public int BuyProp(int price = 100)
    {
        return 0;
    }

    ///取得任務
    ///<param name="indexMission">任務編號</param>
    public void GetMission(int indexMission)
    { 
    }
}

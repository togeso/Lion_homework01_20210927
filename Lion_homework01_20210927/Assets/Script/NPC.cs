using UnityEngine;

/// <summary>NPC �w�q NPC ��k
/// </summary>
public class NPC : MonoBehaviour
{
/// ��ܥ\��
///<param name="dialogue"> NPC �n������ܤ��e</param>>
private void Dialogue(string dialogue)
{
        
}
    ///��s����
    ///<param name="propMission">���ȹD��ƶq</param>
    private int UpdateMisiion(int propMission = 1)
    {
        return 0;
    }

    ///��������
    ///<param name="indexMission">���Ƚs��</param>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }

    ///�}�Ұө�
    public bool OpenShop()
    {
        return true;
    }

    ///�ʶR�D��
    ///<param name="price">�D�����</param>
    public int BuyProp(int price = 100)
    {
        return 0;
    }

    ///���o����
    ///<param name="indexMission">���Ƚs��</param>
    public void GetMission(int indexMission)
    { 
    }
}

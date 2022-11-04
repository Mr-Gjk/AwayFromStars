using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] private GameObject Inventory;
    [SerializeField] private GameObject AnotherUI;
    bool isInventoryOpen;
    public void OpenInventory()
    {
        isInventoryOpen = !isInventoryOpen;
        Inventory.SetActive(isInventoryOpen);
        AnotherUI.SetActive(!isInventoryOpen);
        TimeStop();
    }

    void TimeStop()
    {
        if (isInventoryOpen)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}

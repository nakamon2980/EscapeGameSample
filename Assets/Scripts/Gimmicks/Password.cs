using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Password : MonoBehaviour
{
    // 正解すると、外部の関数を実行する（UnityEvent）
    public UnityEvent ClearEvent;

    // 正解の数値
    [SerializeField] int[] correctNumbers;

    // 現在の数値：passwordButtonのNumberを見ればいい
    [SerializeField] PasswordButton[] passwordButtons;

    // クリックするたびに現在のパネルの数値と正解を比較
    // 一致するならクリアログ

    public void CheckClear()
    {
        if(IsClear())
        {
            Debug.Log("クリアだよ！！！！！！！！！");
            ClearEvent.Invoke();
        }
    }

    bool IsClear()
    {
        // 正解しているかどうか => 1つでも一致しなければfalse
        // 全てのチェックをクリアすればtrue
        for(int i=0; i<correctNumbers.Length; i++)
        {
            if (passwordButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }
        return true;

        /*
        if ((passwordButtons[0].number == correctNumbers[0])
            && (passwordButtons[1].number == correctNumbers[1])
            && (passwordButtons[2].number == correctNumbers[2])
            && (passwordButtons[3].number == correctNumbers[3])
            )
        {
            return true;
        }
        */
    }
}

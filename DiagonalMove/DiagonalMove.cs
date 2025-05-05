/*:
 * @addondesc Allows the character to move diagonally.
 * @author pepaperon-p
 * @help This addon is a dummy for patch management.
 * Please apply the patch as follows:
 * ex.)
 * $ copy RMU_DiagonalMove.patch [project]\Assets\RPGMaker\Codebase
 * $ cd [project]\Assets\RPGMaker\Codebase
 * $ git apply RMU_DiagonalMove.patch
 * 
 * @command doDiagonalMove
 */

/*:ja
 * @addondesc キャラクターの斜め移動を実現します。
 * @author ぺぱぺろん(pepaperon-p)
 * @help このアドオンはパッチ管理用のダミーです。
 * 以下等の様にパッチを適用してください。
 * ex.)
 * $ copy RMU_DiagonalMove.patch [プロジェクト]\Assets\RPGMaker\Codebase
 * $ cd [プロジェクト]\Assets\RPGMaker\Codebase
 * $ git apply RMU_DiagonalMove.patch
 * 
 * @command doDiagonalMove
 */

using RPGMaker.Codebase.CoreSystem.Knowledge.DataModel.Runtime;
using RPGMaker.Codebase.Runtime.Addon;
using RPGMaker.Codebase.Runtime.Common;
using UnityEngine;

namespace RPGMaker.Codebase.Addon
{
  public class DiagonalMove
  {
    public void doDiagonalMove(){}
  }
}

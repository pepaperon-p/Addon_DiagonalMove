# Addon_DiagonalMove
RPGMakerUniteで斜め移動を実現します。<br />
グリッド移動は維持していますので、当たり判定などは同じです。<br />
<br />
※アドオンはパッチの管理用にご使用ください。

パッチの当て方等はこちらをご参照ください。<br />
[【RPGツクール】RPGMakerUniteのアドオン(プラグイン)作成入門 初級編](https://qiita.com/pepaperon_p/items/5b0179164af22d2891e1, "【RPGツクール】RPGMakerUniteのアドオン(プラグイン)作成入門 初級編")

![斜め移動](https://github.com/user-attachments/assets/c0d9a4cd-ad31-4132-9fd7-12482c9aa8ab)

| Addon |
|:-----------|
| [DiagonalMove.cs](https://raw.githubusercontent.com/pepaperon-p/Addon_DiagonalMove/main/DiagonalMove/DiagonalMove.cs "DiagonalMove.cs")|
| [RMU_DiagonalMove.patch](https://raw.githubusercontent.com/pepaperon-p/Addon_DiagonalMove/main/DiagonalMove/RMU_DiagonalMove.patch "RMU_DiagonalMove.patch")|

```mermaid
graph RL;
    RMU_DiagonalMove.patch --  patch --> TileDataModel.cs
    RMU_DiagonalMove.patch --  patch  --> CharacterMoveDirectionEnum.cs
    RMU_DiagonalMove.patch --  patch  --> HandleType.cs
    RMU_DiagonalMove.patch --  patch  --> InputSystemState.cs
    RMU_DiagonalMove.patch --  patch  --> CharacterGraphic.cs
    RMU_DiagonalMove.patch --  patch  --> MapLoop.cs
    RMU_DiagonalMove.patch --  patch  --> MapManager.cs
```
```
$ copy RMU_DiagonalMove.patch [プロジェクト]\Assets\RPGMaker\Codebase
$ cd [プロジェクト]\Assets\RPGMaker\Codebase
$ git apply RMU_DiagonalMove.patch
```



public enum Hero
{
    player_0,
    player_1,
    player_2
}

public enum SceneName
{
    NULL,
    Main,
    Game,
    COUNT
}

public enum BGAudio
{
    Game_BG
}

public enum UIAduio
{
    UI_ClickButton,
    UI_Loading,
    UI_StartGame
}

public enum GameAudio
{
    Fire,
    Power
}

public enum HandMode
{
    RIGHT,
    LEFT
    
}


public enum UILayer
{
    BASE_UI,
    MIDDLE_UI,
    TOP_UI,
    COUNT
}

public enum GameLayer
{
    BACKGROUND = 0,
    PLANE = -1,
    EFFECT = -2
}

public enum BulletOwner
{
    PLAYER,
    ENEMY
}
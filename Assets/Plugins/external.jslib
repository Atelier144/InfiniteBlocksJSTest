mergeInto(LibraryManager.library, {

    GetUsetIdFromJS: function () {
        return GetUserIdFromUnity();
    },

    GetLanguageFromJS: function () {
        return GetLanguageFromUnity();
    },

    SendInfiniteBlocksRecordFromJS: function (userId, score, level) {
        SendInfiniteBlocksRecordFromUnity(userId, score, level);
    },

    GetInfiniteBlocksHighScoreFromJS: function () {
        return GetInfiniteBlocksHighScoreFromUnity();
    },

    SetInfiniteBlocksHighScoreFromJS: function (highScore) {
        SetInfiniteBlocksHighScoreFromUnity(highScore);
    },

    DestroyInfiniteBlocksHighScoreFromJS: function () {
        DestroyInfiniteBlocksHighScoreFromUnity();
    },

    GetInfiniteBlocksMaxLevelFromJS: function () {
        return GetInfiniteBlocksMaxLevelFromUnity();
    },

    SetInfiniteBlocksMaxLevelFromJS: function (maxLevel) {
        SetInfiniteBlocksMaxLevelFromUnity(maxLevel);
    },

    DestroyInfiniteBlocksMaxLevelFromJS: function () {
        DestroyInfiniteBlocksMaxLevelFromUnity();
    }
});

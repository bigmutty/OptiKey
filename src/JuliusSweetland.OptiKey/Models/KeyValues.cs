﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using JuliusSweetland.OptiKey.Enums;
using JuliusSweetland.OptiKey.Properties;

namespace JuliusSweetland.OptiKey.Models
{
    public static class KeyValues
    {
        public static readonly KeyValue AddToDictionaryKey = new KeyValue(FunctionKeys.AddToDictionary);
        public static readonly KeyValue AlphaKeyboardKey = new KeyValue(FunctionKeys.AlphaKeyboard);
        public static readonly KeyValue ArrowDownKey = new KeyValue(FunctionKeys.ArrowDown);
        public static readonly KeyValue ArrowLeftKey = new KeyValue(FunctionKeys.ArrowLeft);
        public static readonly KeyValue ArrowRightKey = new KeyValue(FunctionKeys.ArrowRight);
        public static readonly KeyValue ArrowUpKey = new KeyValue(FunctionKeys.ArrowUp);
        public static readonly KeyValue BackFromKeyboardKey = new KeyValue(FunctionKeys.BackFromKeyboard);
        public static readonly KeyValue BackManyKey = new KeyValue(FunctionKeys.BackMany);
        public static readonly KeyValue BackOneKey = new KeyValue(FunctionKeys.BackOne);
        public static readonly KeyValue BlockyClear = new KeyValue(FunctionKeys.BlockyClear);
        public static readonly KeyValue BlockyABCDEFGHI = new KeyValue(FunctionKeys.BlockyABCDEFGHI);
        public static readonly KeyValue BlockyJKLMNOPQR = new KeyValue(FunctionKeys.BlockyJKLMNOPQR);
        public static readonly KeyValue BlockySTUVWXYZ = new KeyValue(FunctionKeys.BlockySTUVWXYZ);
        public static readonly KeyValue BlockyABC = new KeyValue(FunctionKeys.BlockyABC);
        public static readonly KeyValue BlockyDEF = new KeyValue(FunctionKeys.BlockyDEF);
        public static readonly KeyValue BlockyGHI = new KeyValue(FunctionKeys.BlockyGHI);
        public static readonly KeyValue BlockyJKL = new KeyValue(FunctionKeys.BlockyJKL);
        public static readonly KeyValue BlockyMNO = new KeyValue(FunctionKeys.BlockyMNO);
        public static readonly KeyValue BlockyPQR = new KeyValue(FunctionKeys.BlockyPQR);
        public static readonly KeyValue BlockySTU = new KeyValue(FunctionKeys.BlockySTU);
        public static readonly KeyValue BlockyVWX = new KeyValue(FunctionKeys.BlockyVWX);
        public static readonly KeyValue BlockyYZ = new KeyValue(FunctionKeys.BlockyYZ);
        public static readonly KeyValue BlockyA = new KeyValue(FunctionKeys.BlockyA);
        public static readonly KeyValue BlockyB = new KeyValue(FunctionKeys.BlockyB);
        public static readonly KeyValue BlockyC = new KeyValue(FunctionKeys.BlockyC);
        public static readonly KeyValue BlockyD = new KeyValue(FunctionKeys.BlockyD);
        public static readonly KeyValue BlockyE = new KeyValue(FunctionKeys.BlockyE);
        public static readonly KeyValue BlockyF = new KeyValue(FunctionKeys.BlockyF);
        public static readonly KeyValue BlockyG = new KeyValue(FunctionKeys.BlockyG);
        public static readonly KeyValue BlockyH = new KeyValue(FunctionKeys.BlockyH);
        public static readonly KeyValue BlockyI = new KeyValue(FunctionKeys.BlockyI);
        public static readonly KeyValue BlockyJ = new KeyValue(FunctionKeys.BlockyJ);
        public static readonly KeyValue BlockyK = new KeyValue(FunctionKeys.BlockyK);
        public static readonly KeyValue BlockyL = new KeyValue(FunctionKeys.BlockyL);
        public static readonly KeyValue BlockyM = new KeyValue(FunctionKeys.BlockyM);
        public static readonly KeyValue BlockyN = new KeyValue(FunctionKeys.BlockyN);
        public static readonly KeyValue BlockyO = new KeyValue(FunctionKeys.BlockyO);
        public static readonly KeyValue BlockyP = new KeyValue(FunctionKeys.BlockyP);
        public static readonly KeyValue BlockyQ = new KeyValue(FunctionKeys.BlockyQ);
        public static readonly KeyValue BlockyR = new KeyValue(FunctionKeys.BlockyR);
        public static readonly KeyValue BlockyS = new KeyValue(FunctionKeys.BlockyS);
        public static readonly KeyValue BlockyT = new KeyValue(FunctionKeys.BlockyT);
        public static readonly KeyValue BlockyU = new KeyValue(FunctionKeys.BlockyU);
        public static readonly KeyValue BlockyV = new KeyValue(FunctionKeys.BlockyV);
        public static readonly KeyValue BlockyW = new KeyValue(FunctionKeys.BlockyW);
        public static readonly KeyValue BlockyX = new KeyValue(FunctionKeys.BlockyX);
        public static readonly KeyValue BlockyY = new KeyValue(FunctionKeys.BlockyY);
        public static readonly KeyValue BlockyZ = new KeyValue(FunctionKeys.BlockyZ);
        public static readonly KeyValue BlockyQE = new KeyValue(FunctionKeys.BlockyQE);
        public static readonly KeyValue BlockyNum = new KeyValue(FunctionKeys.BlockyNum);
        public static readonly KeyValue Blocky123 = new KeyValue(FunctionKeys.Blocky123);
        public static readonly KeyValue Blocky456 = new KeyValue(FunctionKeys.Blocky456);
        public static readonly KeyValue Blocky789 = new KeyValue(FunctionKeys.Blocky789);
        public static readonly KeyValue Blocky0 = new KeyValue(FunctionKeys.Blocky0);
        public static readonly KeyValue Blocky1 = new KeyValue(FunctionKeys.Blocky1);
        public static readonly KeyValue Blocky2 = new KeyValue(FunctionKeys.Blocky2);
        public static readonly KeyValue Blocky3 = new KeyValue(FunctionKeys.Blocky3);
        public static readonly KeyValue Blocky4 = new KeyValue(FunctionKeys.Blocky4);
        public static readonly KeyValue Blocky5 = new KeyValue(FunctionKeys.Blocky5);
        public static readonly KeyValue Blocky6 = new KeyValue(FunctionKeys.Blocky6);
        public static readonly KeyValue Blocky7 = new KeyValue(FunctionKeys.Blocky7);
        public static readonly KeyValue Blocky8 = new KeyValue(FunctionKeys.Blocky8);
        public static readonly KeyValue Blocky9 = new KeyValue(FunctionKeys.Blocky9);
        public static readonly KeyValue BlockyAp = new KeyValue(FunctionKeys.BlockyAp);
        public static readonly KeyValue BlockyEx = new KeyValue(FunctionKeys.BlockyEx);
        public static readonly KeyValue BlockyPe = new KeyValue(FunctionKeys.BlockyPe);
        public static readonly KeyValue BreakKey = new KeyValue(FunctionKeys.Break);
        public static readonly KeyValue CalibrateKey = new KeyValue(FunctionKeys.Calibrate);
        public static readonly KeyValue CatalanSpainKey = new KeyValue(FunctionKeys.CatalanSpain);
        public static readonly KeyValue ClearScratchpadKey = new KeyValue(FunctionKeys.ClearScratchpad);
        public static readonly KeyValue CollapseDockKey = new KeyValue(FunctionKeys.CollapseDock);
        public static readonly KeyValue CombiningAcuteAccentKey = new KeyValue("\x0301");
        public static readonly KeyValue CombiningBreveKey = new KeyValue("\x0306");
        public static readonly KeyValue CombiningCaronOrHacekKey = new KeyValue("\x030C");
        public static readonly KeyValue CombiningCedillaKey = new KeyValue("\x0327");
        public static readonly KeyValue CombiningCircumflexKey = new KeyValue("\x0302");
        public static readonly KeyValue CombiningCommaAboveOrSmoothBreathingKey = new KeyValue("\x0313");
        public static readonly KeyValue CombiningCyrillicPsiliPneumataOrSmoothBreathingKey = new KeyValue("\x0486");
        public static readonly KeyValue CombiningDiaeresisOrUmlautKey = new KeyValue("\x0308");
        public static readonly KeyValue CombiningDotAboveKey = new KeyValue("\x0307");
        public static readonly KeyValue CombiningDotAboveRightKey = new KeyValue("\x0358");
        public static readonly KeyValue CombiningDotBelowKey = new KeyValue("\x0323");
        public static readonly KeyValue CombiningDoubleAcuteAccentKey = new KeyValue("\x030B");
        public static readonly KeyValue CombiningDoubleGraveAccentKey = new KeyValue("\x030F");
        public static readonly KeyValue CombiningGraveAccentKey = new KeyValue("\x0300");
        public static readonly KeyValue CombiningHookAboveKey = new KeyValue("\x0309");
        public static readonly KeyValue CombiningHornKey = new KeyValue("\x031B");
        public static readonly KeyValue CombiningInvertedBreveKey = new KeyValue("\x0311");
        public static readonly KeyValue CombiningIotaSubscriptOrYpogegrammeniKey = new KeyValue("\x0345");
        public static readonly KeyValue CombiningMacronKey = new KeyValue("\x0304");
        public static readonly KeyValue CombiningOgonekOrNosineKey = new KeyValue("\x0328");
        public static readonly KeyValue CombiningPalatalizedHookBelowKey = new KeyValue("\x0321");
        public static readonly KeyValue CombiningPerispomeneKey = new KeyValue("\x0342");
        public static readonly KeyValue CombiningRetroflexHookBelowKey = new KeyValue("\x0322");
        public static readonly KeyValue CombiningReversedCommaAboveOrRoughBreathingKey = new KeyValue("\x0314");
        public static readonly KeyValue CombiningRingAboveKey = new KeyValue("\x030A");
        public static readonly KeyValue CombiningRingBelowKey = new KeyValue("\x0325");
        public static readonly KeyValue CombiningTildeKey = new KeyValue("\x0303");
        public static readonly KeyValue CroatianCroatiaKey = new KeyValue(FunctionKeys.CroatianCroatia);
        public static readonly KeyValue ConversationAlphaKeyboardKey = new KeyValue(FunctionKeys.ConversationAlphaKeyboard);
        public static readonly KeyValue ConversationConfirmKeyboardKey = new KeyValue(FunctionKeys.ConversationConfirmKeyboard);
        public static readonly KeyValue ConversationConfirmYesKey = new KeyValue(FunctionKeys.ConversationConfirmYes);
        public static readonly KeyValue ConversationConfirmNoKey = new KeyValue(FunctionKeys.ConversationConfirmNo);
        public static readonly KeyValue ConversationNumericAndSymbolsKeyboardKey = new KeyValue(FunctionKeys.ConversationNumericAndSymbolsKeyboard);
        public static readonly KeyValue Currencies1KeyboardKey = new KeyValue(FunctionKeys.Currencies1Keyboard);
        public static readonly KeyValue Currencies2KeyboardKey = new KeyValue(FunctionKeys.Currencies2Keyboard);
        public static readonly KeyValue CzechCzechRepublicKey = new KeyValue(FunctionKeys.CzechCzechRepublic);
        public static readonly KeyValue DanishDenmarkKey = new KeyValue(FunctionKeys.DanishDenmark);
        public static readonly KeyValue DecreaseOpacityKey = new KeyValue(FunctionKeys.DecreaseOpacity);
        public static readonly KeyValue DeleteKey = new KeyValue(FunctionKeys.Delete);
        public static readonly KeyValue Diacritic1KeyboardKey = new KeyValue(FunctionKeys.Diacritic1Keyboard);
        public static readonly KeyValue Diacritic2KeyboardKey = new KeyValue(FunctionKeys.Diacritic2Keyboard);
        public static readonly KeyValue Diacritic3KeyboardKey = new KeyValue(FunctionKeys.Diacritic3Keyboard);
        public static readonly KeyValue DutchBelgiumKey = new KeyValue(FunctionKeys.DutchBelgium);
        public static readonly KeyValue DutchNetherlandsKey = new KeyValue(FunctionKeys.DutchNetherlands);
        public static readonly KeyValue EndKey = new KeyValue(FunctionKeys.End);
        public static readonly KeyValue EnglishCanadaKey = new KeyValue(FunctionKeys.EnglishCanada);
        public static readonly KeyValue EnglishUKKey = new KeyValue(FunctionKeys.EnglishUK);
        public static readonly KeyValue EnglishUSKey = new KeyValue(FunctionKeys.EnglishUS);
        public static readonly KeyValue ExpandToBottomKey = new KeyValue(FunctionKeys.ExpandToBottom);
        public static readonly KeyValue ExpandToBottomAndLeftKey = new KeyValue(FunctionKeys.ExpandToBottomAndLeft);
        public static readonly KeyValue ExpandToBottomAndRightKey = new KeyValue(FunctionKeys.ExpandToBottomAndRight);
        public static readonly KeyValue ExpandToLeftKey = new KeyValue(FunctionKeys.ExpandToLeft);
        public static readonly KeyValue ExpandToRightKey = new KeyValue(FunctionKeys.ExpandToRight);
        public static readonly KeyValue ExpandToTopKey = new KeyValue(FunctionKeys.ExpandToTop);
        public static readonly KeyValue ExpandToTopAndLeftKey = new KeyValue(FunctionKeys.ExpandToTopAndLeft);
        public static readonly KeyValue ExpandToTopAndRightKey = new KeyValue(FunctionKeys.ExpandToTopAndRight);
        public static readonly KeyValue EscapeKey = new KeyValue(FunctionKeys.Escape);
        public static readonly KeyValue ExpandDockKey = new KeyValue(FunctionKeys.ExpandDock);
        public static readonly KeyValue F1Key = new KeyValue(FunctionKeys.F1);        
        public static readonly KeyValue F2Key = new KeyValue(FunctionKeys.F2);
        public static readonly KeyValue F3Key = new KeyValue(FunctionKeys.F3);
        public static readonly KeyValue F4Key = new KeyValue(FunctionKeys.F4);
        public static readonly KeyValue F5Key = new KeyValue(FunctionKeys.F5);
        public static readonly KeyValue F6Key = new KeyValue(FunctionKeys.F6);
        public static readonly KeyValue F7Key = new KeyValue(FunctionKeys.F7);
        public static readonly KeyValue F8Key = new KeyValue(FunctionKeys.F8);
        public static readonly KeyValue F9Key = new KeyValue(FunctionKeys.F9);
        public static readonly KeyValue F10Key = new KeyValue(FunctionKeys.F10);
        public static readonly KeyValue F11Key = new KeyValue(FunctionKeys.F11);
        public static readonly KeyValue F12Key = new KeyValue(FunctionKeys.F12);
        public static readonly KeyValue F13Key = new KeyValue(FunctionKeys.F13);
        public static readonly KeyValue F14Key = new KeyValue(FunctionKeys.F14);
        public static readonly KeyValue F15Key = new KeyValue(FunctionKeys.F15);
        public static readonly KeyValue F16Key = new KeyValue(FunctionKeys.F16);
        public static readonly KeyValue F17Key = new KeyValue(FunctionKeys.F17);
        public static readonly KeyValue F18Key = new KeyValue(FunctionKeys.F18);
        public static readonly KeyValue F19Key = new KeyValue(FunctionKeys.F19);
        public static readonly KeyValue FrenchFranceKey = new KeyValue(FunctionKeys.FrenchFrance);
        public static readonly KeyValue GermanGermanyKey = new KeyValue(FunctionKeys.GermanGermany);
        public static readonly KeyValue GreekGreeceKey = new KeyValue(FunctionKeys.GreekGreece);
        public static readonly KeyValue HomeKey = new KeyValue(FunctionKeys.Home);
        public static readonly KeyValue IncreaseOpacityKey = new KeyValue(FunctionKeys.IncreaseOpacity);
        public static readonly KeyValue InsertKey = new KeyValue(FunctionKeys.Insert);
        public static readonly KeyValue ItalianItalyKey = new KeyValue(FunctionKeys.ItalianItaly);
        public static readonly KeyValue LanguageKeyboardKey = new KeyValue(FunctionKeys.LanguageKeyboard);
        public static readonly KeyValue LeftAltKey = new KeyValue(FunctionKeys.LeftAlt);
        public static readonly KeyValue LeftCtrlKey = new KeyValue(FunctionKeys.LeftCtrl);
        public static readonly KeyValue LeftShiftKey = new KeyValue(FunctionKeys.LeftShift);
        public static readonly KeyValue LeftWinKey = new KeyValue(FunctionKeys.LeftWin);
        public static readonly KeyValue MenuKey = new KeyValue(FunctionKeys.Menu);
        public static readonly KeyValue MenuKeyboardKey = new KeyValue(FunctionKeys.MenuKeyboard);
        public static readonly KeyValue MinimiseKey = new KeyValue(FunctionKeys.Minimise);
        public static readonly KeyValue MouseDragKey = new KeyValue(FunctionKeys.MouseDrag);
        public static readonly KeyValue MouseKeyboardKey = new KeyValue(FunctionKeys.MouseKeyboard);
        public static readonly KeyValue MouseLeftClickKey = new KeyValue(FunctionKeys.MouseLeftClick);
        public static readonly KeyValue MouseLeftDoubleClickKey = new KeyValue(FunctionKeys.MouseLeftDoubleClick);
        public static readonly KeyValue MouseLeftDownUpKey = new KeyValue(FunctionKeys.MouseLeftDownUp);
        public static readonly KeyValue MouseMagneticCursorKey = new KeyValue(FunctionKeys.MouseMagneticCursor);
        public static readonly KeyValue MouseMiddleClickKey = new KeyValue(FunctionKeys.MouseMiddleClick);
        public static readonly KeyValue MouseMiddleDownUpKey = new KeyValue(FunctionKeys.MouseMiddleDownUp);
        public static readonly KeyValue MouseMoveAmountInPixelsKey = new KeyValue(FunctionKeys.MouseMoveAmountInPixels);
        public static readonly KeyValue MouseMoveAndLeftClickKey = new KeyValue(FunctionKeys.MouseMoveAndLeftClick);
        public static readonly KeyValue MouseMoveAndLeftDoubleClickKey = new KeyValue(FunctionKeys.MouseMoveAndLeftDoubleClick);
        public static readonly KeyValue MouseMoveAndMiddleClickKey = new KeyValue(FunctionKeys.MouseMoveAndMiddleClick);
        public static readonly KeyValue MouseMoveAndRightClickKey = new KeyValue(FunctionKeys.MouseMoveAndRightClick);
        public static readonly KeyValue MouseMoveToKey = new KeyValue(FunctionKeys.MouseMoveTo);
        public static readonly KeyValue MouseMoveToBottomKey = new KeyValue(FunctionKeys.MouseMoveToBottom);
        public static readonly KeyValue MouseMoveToLeftKey = new KeyValue(FunctionKeys.MouseMoveToLeft);
        public static readonly KeyValue MouseMoveToRightKey = new KeyValue(FunctionKeys.MouseMoveToRight);
        public static readonly KeyValue MouseMoveToTopKey = new KeyValue(FunctionKeys.MouseMoveToTop);
        public static readonly KeyValue MouseRightClickKey = new KeyValue(FunctionKeys.MouseRightClick);
        public static readonly KeyValue MouseRightDownUpKey = new KeyValue(FunctionKeys.MouseRightDownUp);
        public static readonly KeyValue MouseScrollAmountInClicksKey = new KeyValue(FunctionKeys.MouseScrollAmountInClicks);
        public static readonly KeyValue MouseScrollToTopKey = new KeyValue(FunctionKeys.MouseScrollToTop);
        public static readonly KeyValue MouseScrollToBottomKey = new KeyValue(FunctionKeys.MouseScrollToBottom);
        public static readonly KeyValue MouseMoveAndScrollToBottomKey = new KeyValue(FunctionKeys.MouseMoveAndScrollToBottom);
        public static readonly KeyValue MouseMoveAndScrollToLeftKey = new KeyValue(FunctionKeys.MouseMoveAndScrollToLeft);
        public static readonly KeyValue MouseMoveAndScrollToRightKey = new KeyValue(FunctionKeys.MouseMoveAndScrollToRight);
        public static readonly KeyValue MouseMoveAndScrollToTopKey = new KeyValue(FunctionKeys.MouseMoveAndScrollToTop);
        public static readonly KeyValue MouseMagnifierKey = new KeyValue(FunctionKeys.MouseMagnifier);
        public static readonly KeyValue MoveAndResizeAdjustmentAmountKey = new KeyValue(FunctionKeys.MoveAndResizeAdjustmentAmount);
        public static readonly KeyValue MoveToBottomKey = new KeyValue(FunctionKeys.MoveToBottom);
        public static readonly KeyValue MoveToBottomAndLeftKey = new KeyValue(FunctionKeys.MoveToBottomAndLeft);
        public static readonly KeyValue MoveToBottomAndLeftBoundariesKey = new KeyValue(FunctionKeys.MoveToBottomAndLeftBoundaries);
        public static readonly KeyValue MoveToBottomAndRightKey = new KeyValue(FunctionKeys.MoveToBottomAndRight);
        public static readonly KeyValue MoveToBottomAndRightBoundariesKey = new KeyValue(FunctionKeys.MoveToBottomAndRightBoundaries);
        public static readonly KeyValue MoveToBottomBoundaryKey = new KeyValue(FunctionKeys.MoveToBottomBoundary);
        public static readonly KeyValue MoveToLeftKey = new KeyValue(FunctionKeys.MoveToLeft);
        public static readonly KeyValue MoveToLeftBoundaryKey = new KeyValue(FunctionKeys.MoveToLeftBoundary);
        public static readonly KeyValue MoveToRightKey = new KeyValue(FunctionKeys.MoveToRight);
        public static readonly KeyValue MoveToRightBoundaryKey = new KeyValue(FunctionKeys.MoveToRightBoundary);
        public static readonly KeyValue MoveToTopKey = new KeyValue(FunctionKeys.MoveToTop);
        public static readonly KeyValue MoveToTopAndLeftKey = new KeyValue(FunctionKeys.MoveToTopAndLeft);
        public static readonly KeyValue MoveToTopAndLeftBoundariesKey = new KeyValue(FunctionKeys.MoveToTopAndLeftBoundaries);
        public static readonly KeyValue MoveToTopAndRightKey = new KeyValue(FunctionKeys.MoveToTopAndRight);
        public static readonly KeyValue MoveToTopAndRightBoundariesKey = new KeyValue(FunctionKeys.MoveToTopAndRightBoundaries);
        public static readonly KeyValue MoveToTopBoundaryKey = new KeyValue(FunctionKeys.MoveToTopBoundary);
        public static readonly KeyValue MultiKeySelectionIsOnKey = new KeyValue(FunctionKeys.MultiKeySelectionIsOn);
        public static readonly KeyValue NextSuggestionsKey = new KeyValue(FunctionKeys.NextSuggestions);
        public static readonly KeyValue NoQuestionResultKey = new KeyValue(FunctionKeys.NoQuestionResult);
        public static readonly KeyValue NumberLockKey = new KeyValue(FunctionKeys.NumberLock);
        public static readonly KeyValue NumericAndSymbols1KeyboardKey = new KeyValue(FunctionKeys.NumericAndSymbols1Keyboard);
        public static readonly KeyValue NumericAndSymbols2KeyboardKey = new KeyValue(FunctionKeys.NumericAndSymbols2Keyboard);
        public static readonly KeyValue NumericAndSymbols3KeyboardKey = new KeyValue(FunctionKeys.NumericAndSymbols3Keyboard);
        public static readonly KeyValue PgDnKey = new KeyValue(FunctionKeys.PgDn);
        public static readonly KeyValue PgUpKey = new KeyValue(FunctionKeys.PgUp);
        public static readonly KeyValue PhysicalKeysKeyboardKey = new KeyValue(FunctionKeys.PhysicalKeysKeyboard);
        public static readonly KeyValue PortuguesePortugalKey = new KeyValue(FunctionKeys.PortuguesePortugal);
        public static readonly KeyValue PreviousSuggestionsKey = new KeyValue(FunctionKeys.PreviousSuggestions);
        public static readonly KeyValue PrintScreenKey = new KeyValue(FunctionKeys.PrintScreen);
        public static readonly KeyValue QuitKey = new KeyValue(FunctionKeys.Quit);
        public static readonly KeyValue RepeatLastMouseActionKey = new KeyValue(FunctionKeys.RepeatLastMouseAction);
        public static readonly KeyValue RussianRussiaKey = new KeyValue(FunctionKeys.RussianRussia);
        public static readonly KeyValue ScrollLockKey = new KeyValue(FunctionKeys.ScrollLock);
        public static readonly KeyValue ShrinkFromBottomKey = new KeyValue(FunctionKeys.ShrinkFromBottom);
        public static readonly KeyValue ShrinkFromBottomAndLeftKey = new KeyValue(FunctionKeys.ShrinkFromBottomAndLeft);
        public static readonly KeyValue ShrinkFromBottomAndRightKey = new KeyValue(FunctionKeys.ShrinkFromBottomAndRight);
        public static readonly KeyValue ShrinkFromLeftKey = new KeyValue(FunctionKeys.ShrinkFromLeft);
        public static readonly KeyValue ShrinkFromRightKey = new KeyValue(FunctionKeys.ShrinkFromRight);
        public static readonly KeyValue ShrinkFromTopKey = new KeyValue(FunctionKeys.ShrinkFromTop);
        public static readonly KeyValue ShrinkFromTopAndLeftKey = new KeyValue(FunctionKeys.ShrinkFromTopAndLeft);
        public static readonly KeyValue ShrinkFromTopAndRightKey = new KeyValue(FunctionKeys.ShrinkFromTopAndRight);
        public static readonly KeyValue SizeAndPositionKeyboardKey = new KeyValue(FunctionKeys.SizeAndPositionKeyboard);
        public static readonly KeyValue SleepKey = new KeyValue(FunctionKeys.Sleep);
        public static readonly KeyValue SlovakSlovakiaKey = new KeyValue(FunctionKeys.SlovakSlovakia);
        public static readonly KeyValue SlovenianSloveniaKey = new KeyValue(FunctionKeys.SlovenianSlovenia);
        public static readonly KeyValue SpeakKey = new KeyValue(FunctionKeys.Speak);
        public static readonly KeyValue SpanishSpainKey = new KeyValue(FunctionKeys.SpanishSpain);
        public static readonly KeyValue Suggestion1Key = new KeyValue(FunctionKeys.Suggestion1);
        public static readonly KeyValue Suggestion2Key = new KeyValue(FunctionKeys.Suggestion2);
        public static readonly KeyValue Suggestion3Key = new KeyValue(FunctionKeys.Suggestion3);
        public static readonly KeyValue Suggestion4Key = new KeyValue(FunctionKeys.Suggestion4);
        public static readonly KeyValue Suggestion5Key = new KeyValue(FunctionKeys.Suggestion5);
        public static readonly KeyValue Suggestion6Key = new KeyValue(FunctionKeys.Suggestion6);
        public static readonly KeyValue TurkishTurkeyKey = new KeyValue(FunctionKeys.TurkishTurkey);
        public static readonly KeyValue YesQuestionResultKey = new KeyValue(FunctionKeys.YesQuestionResult);
        
        private static readonly Dictionary<Languages, List<KeyValue>> multiKeySelectionKeys;

        static KeyValues()
        {
            var defaultList = "abcdefghijklmnopqrstuvwxyz"
                .ToCharArray()
                .Select(c => new KeyValue(c.ToString(CultureInfo.InvariantCulture)))
                .ToList();

            multiKeySelectionKeys = new Dictionary<Languages, List<KeyValue>>
            {
                { Languages.CatalanSpain, "abcdefghijklmnopqrstuvwxyzñç"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.CroatianCroatia, "abcčćdđefghijklmnopqrsštuvwxyzž"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                 { Languages.CzechCzechRepublic, "aábcčdďeéěfghiíjklmnňoópqrřsštťuúůvwxyýzž"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.DanishDenmark, "abcdefghijklmnopqrstuvxyzæøå"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.DutchBelgium, defaultList },
                { Languages.DutchNetherlands, defaultList },
                { Languages.EnglishCanada, defaultList },
                { Languages.EnglishUK, defaultList },
                { Languages.EnglishUS, defaultList },
                { Languages.FrenchFrance, defaultList },
                { Languages.GermanGermany, "abcdefghijklmnopqrstuvwxyzß"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.GreekGreece, "ασδφγηξκλ;ςερτυθιοπζχψωβνμ"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.ItalianItaly, defaultList },
                { Languages.PortuguesePortugal, defaultList },
                { Languages.RussianRussia, "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList() },
                { Languages.SlovakSlovakia, "aáäbcčdďeéfghchiíjklĺľmnoóôpqrŕsštťuúvwxyýzž"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.SlovenianSlovenia, "abcčćdđefghijklmnopqrsštuvwxyzž"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
				{ Languages.SpanishSpain, "abcdefghijklmnopqrstuvwxyzñ"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                },
                { Languages.TurkishTurkey, "abcçdefgğhiıjklmnoöprsştuüvyz"
                                                .ToCharArray()
                                                .Select(c => new KeyValue (c.ToString(CultureInfo.InvariantCulture) ))
                                                .ToList()
                }
            };
        }

        public static List<KeyValue> KeysWhichCanBePressedDown
        {
            get
            {
                return CombiningKeys.Concat(
                    new List <KeyValue>
                    {
                        LeftAltKey,
                        LeftCtrlKey,
                        LeftShiftKey,
                        LeftWinKey,
                        MouseMagnifierKey,
                        MultiKeySelectionIsOnKey
                    })
                    .ToList();
            }
        }

        public static List<KeyValue> KeysWhichCanBeLockedDown
        {
            get
            {
                return new List<KeyValue>
                {
                    LeftAltKey,
                    LeftCtrlKey,
                    LeftShiftKey,
                    LeftWinKey,
                    MouseLeftDownUpKey,
                    MouseMagneticCursorKey,
                    MouseMagnifierKey,
                    MouseMiddleDownUpKey,
                    MouseRightDownUpKey,
                    MultiKeySelectionIsOnKey,
                    SleepKey
                };
            }
        }

        public static List<KeyValue> KeysWhichCanBePressedOrLockedDown
        {
            get
            {
                return KeysWhichCanBePressedDown.Concat(KeysWhichCanBeLockedDown).Distinct().ToList();
            }
        }

        public static List<KeyValue> KeysWhichPreventTextCaptureIfDownOrLocked
        {
            get
            {
                return new List<KeyValue>
                {
                    LeftAltKey,
                    LeftCtrlKey,
                    LeftWinKey
                };
            }
        }

        public static List<KeyValue> CombiningKeys
        {
            get
            {
                return new List<KeyValue>
                {
                    //N.B. The order of these key values is important. This is the order in which combining keys which are down will be composed into a primary composite.
                    CombiningDiaeresisOrUmlautKey, //Diaeresis must be before the AcuteAccent if they are to combine into a COMBINING GREEK DIALYTIKA TONOS U+0344
                    CombiningAcuteAccentKey, //AuteAccent must be after the Diaeresis if they are to combine into a COMBINING GREEK DIALYTIKA TONOS U+0344
                    CombiningBreveKey,
                    CombiningCaronOrHacekKey,
                    CombiningCedillaKey,
                    CombiningCircumflexKey,
                    CombiningCommaAboveOrSmoothBreathingKey,
                    CombiningCyrillicPsiliPneumataOrSmoothBreathingKey,
                    CombiningDotAboveKey,
                    CombiningDotAboveRightKey,
                    CombiningDotBelowKey,
                    CombiningDoubleAcuteAccentKey,
                    CombiningDoubleGraveAccentKey,
                    CombiningGraveAccentKey,
                    CombiningHookAboveKey,
                    CombiningHornKey,
                    CombiningInvertedBreveKey,
                    CombiningIotaSubscriptOrYpogegrammeniKey,
                    CombiningMacronKey,
                    CombiningOgonekOrNosineKey,
                    CombiningPalatalizedHookBelowKey,
                    CombiningPerispomeneKey,
                    CombiningRetroflexHookBelowKey,
                    CombiningReversedCommaAboveOrRoughBreathingKey,
                    CombiningRingAboveKey,
                    CombiningRingBelowKey,
                    CombiningTildeKey
                };
            }
        }

        /// <summary>
        /// Keys which are published when OptiKey is publishing (simulating key strokes). Otherwise these keys have no impact 
        /// on text within OptiKey (which is why LeftShift is not included as this modifies the case of entered text).
        /// </summary>
        public static List<KeyValue> PublishOnlyKeys
        {
            get
            {
                return new List<KeyValue>
                {
                    new KeyValue(FunctionKeys.LeftCtrl),
                    new KeyValue(FunctionKeys.LeftWin),
                    new KeyValue(FunctionKeys.LeftAlt),
                    new KeyValue(FunctionKeys.F1),
                    new KeyValue(FunctionKeys.F2),
                    new KeyValue(FunctionKeys.F3),
                    new KeyValue(FunctionKeys.F4),
                    new KeyValue(FunctionKeys.F5),
                    new KeyValue(FunctionKeys.F6),
                    new KeyValue(FunctionKeys.F7),
                    new KeyValue(FunctionKeys.F8),
                    new KeyValue(FunctionKeys.F9),
                    new KeyValue(FunctionKeys.F10),
                    new KeyValue(FunctionKeys.F11),
                    new KeyValue(FunctionKeys.F12),
                    new KeyValue(FunctionKeys.F13),
                    new KeyValue(FunctionKeys.F14),
                    new KeyValue(FunctionKeys.F15),
                    new KeyValue(FunctionKeys.F16),
                    new KeyValue(FunctionKeys.F17),
                    new KeyValue(FunctionKeys.F18),
                    new KeyValue(FunctionKeys.F19),
                    new KeyValue(FunctionKeys.PrintScreen),
                    new KeyValue(FunctionKeys.ScrollLock),
                    new KeyValue(FunctionKeys.NumberLock),
                    new KeyValue(FunctionKeys.Menu),
                    new KeyValue(FunctionKeys.ArrowUp),
                    new KeyValue(FunctionKeys.ArrowLeft),
                    new KeyValue(FunctionKeys.ArrowRight),
                    new KeyValue(FunctionKeys.ArrowDown),
                    new KeyValue(FunctionKeys.Break),
                    new KeyValue(FunctionKeys.Insert),
                    new KeyValue(FunctionKeys.Home),
                    new KeyValue(FunctionKeys.PgUp),
                    new KeyValue(FunctionKeys.PgDn),
                    new KeyValue(FunctionKeys.Delete),
                    new KeyValue(FunctionKeys.End),
                    new KeyValue(FunctionKeys.Escape)
                };
            }
        }

        public static List<KeyValue> MultiKeySelectionKeys
        {
            get { return multiKeySelectionKeys[Settings.Default.KeyboardAndDictionaryLanguage]; }
        }
    }
}

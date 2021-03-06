using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

/*  Author: Mike
 * 
 *  Full Oryx the Mad God 1 behaviors.
 * 
 *  ToS:
 *  you MUST give credits, if you use this behavior.
 * 
 * */

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ oryxone = () => Behav()
        #region Minions
        .Init("White Moon",
            new State(
                new State("Ini",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                    new Shoot(5, coolDownOffset: 1500, count: 10, coolDown: 700, projectileIndex: 0, shootAngle: 36, defaultAngle: 0),
                    new Shoot(5, coolDownOffset: 1850, count: 10, coolDown: 700, projectileIndex: 0, shootAngle: 36, defaultAngle: 18),
                    new Orbit(4, 13.4, 20, "Oryx the Mad God 1"),
                    new Decay(19000)
                    )
                )
            )
        .Init("White Planet",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new Shoot(14, coolDownOffset: 1400, count: 10, coolDown: 1000, projectileIndex: 0, shootAngle: 36, defaultAngle: 0),
                new State("Wide",
                    new Orbit(.75, 9, 15, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Small")
                    ),
                new State("Small",
                    new Orbit(.95, 3, 15, "Oryx the Mad God 1")
                    ),
                new Decay(19000)
                )
            )
        .Init("Chase Element",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Attacking",
                    new Shoot(14, 10, coolDown: 800, projectileIndex: 0, shootAngle: 36),
                    new Shoot(0, coolDownOffset: 0, count: 4, coolDown: 25, projectileIndex: 1, shootAngle: 90, defaultAngle: 0)
                    ),
                new Decay(19600)
                )
            )
        .Init("Anti-Spectator",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Ini",
                    new Shoot(5, coolDownOffset: 1500, shootAngle: 36, count: 10, coolDown: 700, defaultAngle: 0),
                    new Shoot(5, coolDownOffset: 1850, shootAngle: 36, count: 10, coolDown: 700, defaultAngle: 18),
                    new Orbit(4, 12, 20, "Oryx the Mad God 1")
                    ),
                new Decay(18000)
                )
            )
        .Init("Ring Element",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Setup",
                    new TimedTransition(1000, "Warning_shot")
                    ),
                new State("Warning_shot",
                    new Shoot(14, 12, 30, 1, coolDown: 800),
                    new TimedTransition(1000, "Attacking")
                    ),
                new State("Attacking",
                    new Shoot(14, 12, 30, 0, coolDown: 800)
                    ),
                new Decay(19000)
                )
            )
        .Init("Minion of Oryx",
            new State(
                new State("Oryx",
                    new State("Attacking1",
                        new Wander(0.6),
                        new TimedTransition(3000, "Attacking2")
                        ),
                    new State("Attacking2",
                        new Orbit(0.8, 3.5, 8),
                        new Wander(0.8),
                        new TimedTransition(4000, "Attacking1")
                        ),
                    new Shoot(14, 3, 12, 0, coolDown: 800),
                    new Shoot(14, coolDownOffset: 400, predictive: 0.35, count: 2, coolDown: 1000, projectileIndex: 1, shootAngle: 180)
                    )
                )
            )
        .Init("Guardian Element 1",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Setup",
                    new Orbit(1, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(2000, "Attacking1")
                    ),
                new State("Attacking1",
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 0),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding1")
                    ),
                new State("Shielding1",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking2")
                    ),
                new State("Attacking2",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 45),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding2")
                    ),
                new State("Shielding2",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking3")
                    ),
                new State("Attacking3",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 0),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Kamikazee")
                    ),
                new State("Kamikazee",
                    new Decay(2300),
                    new Flash(0x00FF00, 0.2, 12),
                    new Orbit(0.8, 4, 10, "Oryx the Mad God 1")
                    )
                )
            )
        .Init("Guardian Element 2",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Setup",
                    new Orbit(1, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(2000, "Attacking1")
                    ),
                new State("Attacking1",
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 90),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding1")
                    ),
                new State("Shielding1",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking2")
                    ),
                new State("Attacking2",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 135),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding2")
                    ),
                new State("Shielding2",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking3")
                    ),
                new State("Attacking3",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 90),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Kamikazee")
                    ),
                new State("Kamikazee",
                    new Decay(2300),
                    new Flash(0x00FF00, 0.2, 12),
                    new Orbit(0.8, 4, 10, "Oryx the Mad God 1")
                    )
                )
            )
        .Init("Guardian Element 3",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Setup",
                    new Orbit(1, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(2000, "Attacking1")
                    ),
                new State("Attacking1",
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 180),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding1")
                    ),
                new State("Shielding1",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking2")
                    ),
                new State("Attacking2",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 225),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding2")
                    ),
                new State("Shielding2",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking3")
                    ),
                new State("Attacking3",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 180),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Kamikazee")
                    ),
                new State("Kamikazee",
                    new Decay(2300),
                    new Flash(0x00FF00, 0.2, 12),
                    new Orbit(0.8, 4, 10, "Oryx the Mad God 1")
                    )
                )
            )
        .Init("Guardian Element 4",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Setup",
                    new Orbit(1, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(2000, "Attacking1")
                    ),
                new State("Attacking1",
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 270),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding1")
                    ),
                new State("Shielding1",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking2")
                    ),
                new State("Attacking2",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 315),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Shielding2")
                    ),
                new State("Shielding2",
                    new ChangeSize(11, 230),
                    new Shoot(14, 5, 72, 0, coolDown: 1200),
                    new Orbit(5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(5000, "Attacking3")
                    ),
                new State("Attacking3",
                    new ChangeSize(-11, 130),
                    new Shoot(14, 1, 0, 0, coolDown: 600, defaultAngle: 270),
                    new Orbit(1.5, 2, 10, "Oryx the Mad God 1"),
                    new TimedTransition(6000, "Kamikazee")
                    ),
                new State("Kamikazee",
                    new Decay(2300),
                    new Flash(0x00FF00, 0.2, 12),
                    new Orbit(0.8, 4, 10, "Oryx the Mad God 1")
                    )
                )
            )
        .Init("Outer Guardian Element",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable, true),
                new State("Ini",
                    new Shoot(3, predictive: 0.45, count: 3, coolDown: 1200, projectileIndex: 0),
                    new Orbit(3.2, 8.5, 20, "Oryx the Mad God 1")
                    ),
                new Decay(32000)
                )
            )
        .Init("Assassin of Oryx",
            new State(
                new State("Ini",
                    new EntityNotExistsTransition("Oryx the Mad God 1", 999, "NoOryx"),
                    new Charge(1.6, 20, 2400),
                    new TimedTransition(800, "OrbitOryx", true),
                    new TimedTransition(800, "ChaseAttack", true)
                    ),
                new State("OrbitOryx",
                    new EntityNotExistsTransition("Oryx the Mad God 1", 999, "NoOryx"),
                    new Orbit(1.4, 12, 20, "Oryx the Mad God 1", 0.5, 1.5),
                    new Shoot(9, 4, coolDownOffset: 0, projectileIndex: 1, shootAngle: 90, defaultAngle: 0),
                    new TimedTransition(2200, "ChaseAttack")
                    ),
                new State("ChaseAttack",
                    new EntityNotExistsTransition("Oryx the Mad God 1", 999, "NoOryx"),
                    new Charge(1.6, 12, 2400),
                    new Orbit(1.4, 3, 15),
                    new Shoot(6, coolDownOffset: 0, predictive: 0.75, count: 3, coolDown: 1000, projectileIndex: 0, shootAngle: 20, defaultAngle: 0),
                    new Shoot(9, coolDownOffset: 400, count: 4, coolDown: 3200, projectileIndex: 1, shootAngle: 90, defaultAngle: 0),
                    new TimedTransition(7000, "OrbitOryx")
                    ),
                new State("NoOryx",
                    new State("Chase",
                        new Orbit(1, 7, 15),
                        new Charge(1.4, 12, 2400),
                        new TimedTransition(1000, "Wander")
                        ),
                    new State("Wander",
                        new SetAltTexture(1),
                        new Wander(0),
                        new TimedTransition(1000, "Chase")
                        ),
                    new Flash(0xFFFFFF, 0.2, 10),
                    new Decay(5000)
                    )
                )
            )
        #endregion
        #region Oryx
        .Init("Oryx the mad god 1",
            new State(
        #endregion
        #region Start
         new State("start_the_fun",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new PlayerWithinTransition(12, "just_like_old_times")
                    ),
                new State("just_like_old_times",
                    new StayCloseToSpawn(0.4, 5),
                    new Wander(0.4),
                    new Shoot(12, coolDownOffset: 1000, predictive: 0.5, count: 9, coolDown: 800, projectileIndex: 3, shootAngle: 10),
                    new Shoot(12, coolDownOffset: 1000, count: 1, coolDown: 800, projectileIndex: 4),
                    new HpLessTransition(0.97, "CircleCombat")
                    ),
        #endregion
        #region MakeMinios
                new State("MakeMinions",
                    new HpLessTransition(0.060, "AllIn"),
                    new Taunt(0.75, true, "Go forth minions! Crush these weaklings!!!"),
                    new StayCloseToSpawn(0.4, 5),
                    new Wander(0.4),
                    new Spawn("Minion of Oryx", 5, coolDown: 300),
                    new Shoot(22, 4, coolDown: 800, projectileIndex: 4),
                    new State("invulnerable19",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TimedTransition(6000, "vulnerable9")
                        ),
                    new State("vulnerable9",
                        new TimedTransition(1500, "invulnerable29"),
                        new HpLessTransition(0.45, "invulnerable29")
                        ),
                    new State("invulnerable29",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                        ),
                    new TimedTransition(12000, "BulletDance")
                        ),
        #endregion
        #region Pick State
                new State("AttackDone",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new RemoveEntity(50, "Minion of Oryx"),
                    new RemoveEntity(50, "Assassin of Oryx"),
                    new Taunt(1.0, true,
                        "Bah! I need no minions to destroy you!!",
                        "I will finish you off myself!",
                        "These minions will only get in my way!!!",
                        "Leave me my minions... I wish to crush tme PERSONALLY!",
                        "Fools! I will deal with you PERSONALLY!"),
                    new Flash(0x00FF00, 0.2, 20),
                    new TimedTransition(5200, "ActualDone")
                    ),
                new State("ActualDone",
                    new TimedTransition(0, "WhitePlanet"),
                    new TimedTransition(0, "ArtifactDance"),
                    new TimedTransition(0, "Hadouken"),
                    new TimedTransition(0, "MinionToss"),
                    new TimedTransition(0, "BulletDance"),
                    new TimedTransition(0, "ChaseCourse"),
                    new TimedTransition(0, "Orbitals"),
                    new TimedTransition(0, "CircleCombat")
                    ),
        #endregion
        #region White Planet
                new State("WhitePlanet",
                    new HpLessTransition(0.060, "AllIn"),
                    new State("Inigayass",
                        new RemoveEntity(50, "Minion of Oryx"),
                        new RemoveEntity(50, "Assassin of Oryx"),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new StayCloseToSpawn(1, 0),
                        new Taunt(1.00, true, "I am the master of this existence!!!", "I control your fate!", "The universe bends to my will alone!"),
                        new TimedTransition(1600, "asdfasdfasdfsafasdfasdfasdfasdf")
                        ),
                    new State("asdfasdfasdfsafasdfasdfasdfasdf",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TossObject("White Moon", 13.4, coolDown: 10000 * 1000, angle: 0),
                        new TossObject("White Moon", 13.4, coolDown: 10000 * 1000, angle: 90),
                        new TossObject("White Moon", 13.4, coolDown: 10000 * 1000, angle: 180),
                        new TossObject("White Moon", 13.4, coolDown: 10000 * 1000, angle: 270),
                        new TossObject("White Planet", 9.0, coolDown: 10000 * 1000, angle: 45),
                        new TossObject("White Planet", 9.0, coolDown: 10000 * 1000, angle: 135),
                        new TossObject("White Planet", 9.0, coolDown: 10000 * 1000, angle: 225),
                        new TossObject("White Planet", 9.0, coolDown: 10000 * 1000, angle: 315),
                        new TimedTransition(200, "oasdfoasdjfoasdof")
                        ),
                    new State("oasdfoasdjfoasdof",
                        new State("ojqwneorqweorjqoweroqwer",
                            new State("invulnerableswag",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                new TimedTransition(3600, "vulnerableswag")
                                ),
                            new State("vulnerableswag",
                                new TimedTransition(1000, "invulnerableswag")
                                ),
                        new Shoot(0, coolDownOffset: 0, count: 24, coolDown: 2000, projectileIndex: 6, shootAngle: 15, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 600, count: 36, coolDown: 90000, projectileIndex: 11, shootAngle: 10, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 1000, count: 10, coolDown: 2000, projectileIndex: 14, shootAngle: 36, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 2000, count: 10, coolDown: 2000, projectileIndex: 14, shootAngle: 36, defaultAngle: 18),
                        new TimedTransition(4000, "Attack2dafadsf")
                        ),
                    new State("Attack2dafadsf",
                        new State("shieldCyclezxvczxcvzxcvzxcv",
                            new State("invulnerablezxcvzxcvzxcvzxcv",
                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                new TimedTransition(3600, "vulnerab234523452345le")
                                ),
                            new State("vulnerab234523452345le",
                                new TimedTransition(1000, "invulnerablezxcvzxcvzxcvzxcv")
                                ),
                        new Shoot(0, coolDownOffset: 0, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 200, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 12),
                        new Shoot(0, coolDownOffset: 400, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 24),
                        new Shoot(0, coolDownOffset: 600, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 36),
                        new Shoot(0, coolDownOffset: 800, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 48),
                        new Shoot(0, coolDownOffset: 1000, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 60),
                        new Shoot(0, coolDownOffset: 1200, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 72),
                        new Shoot(0, coolDownOffset: 1400, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 84),
                        new Shoot(0, coolDownOffset: 1600, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 96),
                        new Shoot(0, coolDownOffset: 1800, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 108),
                        new Shoot(0, coolDownOffset: 2000, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 120),
                        new Shoot(0, coolDownOffset: 2200, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 132),
                        new Shoot(0, coolDownOffset: 2400, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 144),
                        new Shoot(0, coolDownOffset: 2600, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 156),
                        new Shoot(0, coolDownOffset: 2800, count: 4, coolDown: 3000, projectileIndex: 5, shootAngle: 90, defaultAngle: 168),
                        new TimedTransition(8000, "oasdfoasdjfoasdofasdfasdf")
                        ),
                    new State("oasdfoasdjfoasdofasdfasdf",
                        new Taunt(0.8, true, "You have uttered your last pathetic whimper!", "SILENCE!", "Speak no more, fools!", "You have spoken your last!"),
                        new Shoot(0, coolDownOffset: 0, count: 24, coolDown: 2000, projectileIndex: 6, shootAngle: 15, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 600, count: 36, coolDown: 90000, projectileIndex: 11, shootAngle: 10, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 1000, count: 10, coolDown: 2000, projectileIndex: 14, shootAngle: 36, defaultAngle: 0),
                        new Shoot(0, coolDownOffset: 2000, count: 10, coolDown: 2000, projectileIndex: 14, shootAngle: 36, defaultAngle: 18),
                        new TimedTransition(7000, "Attack2dafadsf")
                        ),
                    new TimedTransition(20000, "AttackDone"
        #endregion
        #region AllIn
                        ),
                    new State("AllIn",
                        new State("Inilololololololololololo",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new StayCloseToSpawn(1, 0),
                            new Taunt(1.0, true, "THIS SHALL BE YOUR GRAVE!!!", "I HAVE HAD ENOUGH OF YOU!!!", "DIE!!!", "ENOUGH!!!"),
                            new SpecificHeal(1, 2500, coolDown: 400, group: "Self"),
                            new TimedTransition(3000, "Summonadsfadf")
                            ),
                        new State("Summonadsfadf",
                            new Flash(0xFF0000, 0.2, 10),
                            new ChangeSize(10, 160),
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, 12, coolDown: 1000, predictive: 0.5, coolDownOffset: 200, projectileIndex: 16, shootAngle: 30, defaultAngle: 0),
                            new TossObject("Assassin of Oryx", 4.3, coolDown: 100000 * 1000, angle: 270),
                            new TossObject("Assassin of Oryx", 4.3, coolDown: 100000 * 1000, angle: 150),
                            new TossObject("Assassin of Oryx", 4.3, coolDown: 100000 * 1000, angle: 30),
                            new TimedTransition(1000, "Chasetwtwtw")
                            ),
                        new State("Chasetwtwtw",
                            new ChangeSize(10, 160),
                            new ConditionalEffect(ConditionEffectIndex.Armored),
                            new Spawn("Assassin of Oryx", 5, coolDown: 5000),
                            new State("Toss1127439812374981234",
                                new State("FlashOrNotasdfasdfadsfasdfa",
                                    new Flash(0xFF0000, 0.2, 12)
                                    ),
                                new State("Flashasdfasdfasdfasdf",
                                    new Flash(0xFF0000, 0.2, 12)
                                    ),
                                new TossObject("Minion of Oryx", 3, angle: 45, randomToss: true, coolDown: 100000 * 1000),
                                new TossObject("Minion of Oryx", 3, angle: 225, randomToss: true, coolDown: 100000 * 1000),
                                new TimedTransition(2200, "Toss2qwopehrqwjperhqpwoer")
                                ),
                            new State("Toss2qwopehrqwjperhqpwoer",
                                new TossObject("Minion of Oryx", 3, angle: 135, randomToss: true, coolDown: 100000 * 1000),
                                new TossObject("Minion of Oryx", 3, angle: 315, randomToss: true, coolDown: 100000 * 1000),
                                new TimedTransition(2200, "ojashdfiashdofajsdof")
                                ),
                            new State("ojashdfiashdofajsdof",
                                new TimedTransition(12000, "Toss1127439812374981234")
                                ),
                            new Charge(1.2, 10, coolDown: 800),
                            new Wander(1.0),
                            new Shoot(14, predictive: 0.75, count: 2, coolDown: 1200, projectileIndex: 1, shootAngle: 16),
                            new Shoot(14, coolDownOffset: 3000, predictive: 1, count: 6, coolDown: 3400, projectileIndex: 16, shootAngle: 25, defaultAngle: 0),
                            new Shoot(14, coolDownOffset: 1000, predictive: .6, count: 4, coolDown: 2000, projectileIndex: 15, shootAngle: 90, defaultAngle: 90),
                            new TimedTransition(20000, "Chasetwtwtw")
        #endregion
        #region CircleCombat
                            ),
                        new State("CircleCombat",
                            new HpLessTransition(0.060, "AllIn"),
                            new State("set_up_the_ring1999999",
                                new State("antispectator11999",
                                    new RemoveEntity(50, "Minion of Oryx"),
                                    new RemoveEntity(50, "Assassin of Oryx"),
                                    new Taunt(1.0, true, "BE SILENT!!!"),
                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                    new TossObject("Minion of Oryx", 20, 0, 10000 * 1000),
                                    new TossObject("Minion of Oryx", 20, 72, 10000 * 1000),
                                    new TossObject("Minion of Oryx", 20, 144, 10000 * 1000),
                                    new TossObject("Minion of Oryx", 20, 216, 10000 * 1000),
                                    new TossObject("Minion of Oryx", 20, 288, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 0, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 24, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 48, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 72, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 96, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 120, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 144, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 168, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 192, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 216, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 240, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 264, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 288, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 312, 10000 * 1000),
                                    new TossObject("Ring Element", 8.5, 336, 10000 * 1000),
                                    new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                    new TimedTransition(600, "antispectator21999")
                                    ),
                                new State("antispectator21999",
                                    new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                    new TimedTransition(600, "antispectator31999")
                                    ),
                                new State("antispectator31999",
                                    new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                    new TimedTransition(600, "antispectator41999")
                                    ),
                                new State("antispectator41999",
                                    new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                    new TimedTransition(600, "no_knight_can_harm_me123412341234")
                                    ),
                                new State("no_knight_can_harm_me123412341234",
                                    new State("grenade0xdddddddddddddddddd",
                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                        new Shoot(14, 36, coolDown: 90000, projectileIndex: 12, shootAngle: 10, defaultAngle: 0),
                                        new Shoot(14, coolDownOffset: 600, count: 36, coolDown: 90000, projectileIndex: 11, shootAngle: 10, defaultAngle: 5),
                                        new Shoot(14, coolDownOffset: 800, count: 15, coolDown: 90000, projectileIndex: 0, shootAngle: 24),
                                        new TimedTransition(1000, "grenade1rrr")
                                        ),
                                    new State("grenade1rrr",
                                        new Shoot(14, coolDownOffset: 400, count: 15, coolDown: 600, projectileIndex: 0, shootAngle: 24),
                                        new Grenade(2.5, 220, 5.5, 210, coolDown: 90000),
                                        new Grenade(2.5, 220, 4.5, 30, coolDown: 90000),
                                        new Grenade(2.5, 220, 5.5, coolDown: 90000),
                                        new TimedTransition(1200, "grenade2rrr")
                                        ),
                                    new State("grenade2rrr",
                                        new Shoot(14, coolDownOffset: 400, count: 15, coolDown: 600, projectileIndex: 0, shootAngle: 24),
                                        new Grenade(2.5, 220, 5.5, 70, coolDown: 90000),
                                        new Grenade(2.5, 220, 4.5, 250, coolDown: 90000),
                                        new Grenade(2.5, 220, 5.5, coolDown: 90000),
                                        new TimedTransition(1200, "grenade3rrr")
                                        ),
                                    new State("grenade3rrr",
                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                        new Shoot(14, coolDownOffset: 400, count: 15, coolDown: 600, projectileIndex: 0, shootAngle: 24),
                                        new Grenade(2.5, 220, 5.5, 0, coolDown: 90000),
                                        new Grenade(2.5, 220, 4.5, 180, coolDown: 90000),
                                        new Grenade(2.5, 220, 5.5, coolDown: 90000),
                                        new TimedTransition(1200, "grenade4rrr")
                                        ),
                                    new State("grenade4rrr",
                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                        new Shoot(14, coolDownOffset: 400, count: 15, coolDown: 600, projectileIndex: 0, shootAngle: 24),
                                        new Grenade(2.5, 220, 5.5, 110, coolDown: 90000),
                                        new Grenade(2.5, 220, 4.5, 290, coolDown: 90000),
                                        new Grenade(2.5, 220, 5.5, coolDown: 90000),
                                        new TimedTransition(1200, "grenade5rrr")
                                        ),
                                    new State("grenade5rrr",
                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                        new Shoot(14, coolDownOffset: 400, count: 15, coolDown: 600, projectileIndex: 0, shootAngle: 24),
                                        new Grenade(2.5, 220, 5.5, 325, coolDown: 90000),
                                        new Grenade(2.5, 220, 4.5, 145, coolDown: 90000),
                                        new Grenade(2.5, 220, 5.5, coolDown: 90000),
                                        new TimedTransition(1200, "grenade0xdddddddddddddddddd")
                                        ),
                                    new TimedTransition(21000, "AttackDone")
        #endregion
        #region ArtifactDance
                                    ),
                                new State("ArtifactDance",
                                    new HpLessTransition(0.060, "AllIn"),
                                    new State("Attacking1sadafsdasfdasfdfasd",
                                        new RemoveEntity(50, "Minion of Oryx"),
                                        new RemoveEntity(50, "Assassin of Oryx"),
                                        new Taunt(1.0, true, "My artifacts will protect me!"),
                                        new TossObject("Guardian Element 1", 2, 0, coolDown: 10000 * 1000),
                                        new TossObject("Guardian Element 2", 2, 90, coolDown: 10000 * 1000),
                                        new TossObject("Guardian Element 3", 2, 180, coolDown: 10000 * 1000),
                                        new TossObject("Guardian Element 4", 2, 270, coolDown: 10000 * 1000),
                                        new TossObject("Outer Guardian Element", 9, 120, coolDown: 10000 * 1000),
                                        new TossObject("Outer Guardian Element", 9, 240, coolDown: 10000 * 1000),
                                        new TossObject("Outer Guardian Element", 9, 360, coolDown: 10000 * 1000),
                                        new Shoot(14, 10, coolDownOffset: 1500, coolDown: 500, projectileIndex: 7, shootAngle: 30),
                                        new State("shieldedvvvvv++++",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(2500, "unshieldedvvvvv++++")
                                            ),
                                        new State("unshieldedvvvvv++++",
                                            new TimedTransition(1000, "shieldedvvvvv++++")
                                            ),
                                        new Shoot(14, coolDownOffset: 15000, count: 3, coolDown: 900, shootAngle: 120, projectileIndex: 9),
                                        new TimedTransition(6000, "Being_defended1++++")
                                        ),
                                    new State("Being_defended1++++",
                                        new State("shieldedccccc++++",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(2500, "unshieldedccccc++++")
                                            ),
                                        new State("unshieldedccccc++++",
                                            new TimedTransition(1000, "shieldedccccc++++")
                                            ),
                                        new Shoot(14, 6, coolDown: 1500, projectileIndex: 8, shootAngle: 45, defaultAngle: 0),
                                        new TimedTransition(5000, "Attacking2++++")
                                        ),
                                    new State("Attacking2++++",
                                        new State("shieldedxxxxx++++",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(2500, "unshieldedxxxxx++++")
                                            ),
                                        new State("unshieldedxxxxx++++",
                                            new TimedTransition(1000, "shieldedxxxxx++++")
                                            ),
                                        new Shoot(14, coolDownOffset: 1500, count: 3, coolDown: 900, shootAngle: 120, projectileIndex: 9),
                                        new TimedTransition(6000, "Being_defended2++++")
                                        ),
                                    new State("Being_defended2++++",
                                        new State("shieldedzzzzz++++",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(2500, "unshieldedzzzzz++++")
                                            ),
                                        new State("unshieldedzzzzz++++",
                                            new TimedTransition(1000, "shieldedzzzzz++++")
                                            ),
                                        new Shoot(14, 6, coolDown: 1500, projectileIndex: 8, shootAngle: 45, defaultAngle: 0),
                                        new TimedTransition(5000, "Attacking3++++")
                                        ),
                                    new State("Attacking3++++",
                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                        new Shoot(14, coolDownOffset: 1500, count: 3, coolDown: 900, projectileIndex: 9, shootAngle: 120)
                                        ),
                                    new TimedTransition(32000, "AttackDone")
        #endregion
        #region Hadouken
                                    ),
                                new State("Hadouken",
                                    new HpLessTransition(0.060, "AllIn"),
                                    new State("Iniaye",
                                        new RemoveEntity(50, "Minion of Oryx"),
                                        new RemoveEntity(50, "Assassin of Oryx"),
                                        new Taunt(1.0, true, "All who look upon my face shall die."),
                                        new HpLessTransition(0.55, "Big'''"),
                                        new HpLessTransition(1.00, "Regular'''")
                                        ),
                                    new State("Big'''",
                                        new Shoot(10, predictive: 0.6, count: 2, coolDown: 500, projectileIndex: 1, shootAngle: 10),
                                        new Shoot(0, 1, coolDownOffset: 200, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 0),
                                        new Shoot(0, 1, coolDownOffset: 400, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 180),
                                        new Shoot(0, 1, coolDownOffset: 600, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 270),
                                        new Shoot(0, 1, coolDownOffset: 800, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 90),
                                        new Shoot(0, 1, coolDownOffset: 1000, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 225),
                                        new Shoot(0, 1, coolDownOffset: 1200, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 45),
                                        new Shoot(0, 1, coolDownOffset: 1400, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 135),
                                        new Shoot(0, 1, coolDownOffset: 1600, coolDown: 1600, projectileIndex: 5, shootAngle: 30, defaultAngle: 315),
                                        new State("invulnerablemo14322143142314231423",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(3500, "vulnerablemo143214231432")
                                            ),
                                        new State("vulnerablemo143214231432",
                                            new TimedTransition(1000, "invulnerablemo14322143142314231423")
                                            )
                                        ),
                                    new State("Regular'''",
                                        new Shoot(10, predictive: 0.6, count: 2, coolDown: 500, projectileIndex: 1, shootAngle: 10),
                                        new State("invulnerable1noafasdfasdfadfdf",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(3500, "vulnerablenoadsfasdfasfdafds")
                                            ),
                                        new State("vulnerablenoadsfasdfasfdafds",
                                            new TimedTransition(1000, "invulnerable2nasdfasdfasfdo")
                                            ),
                                        new State("invulnerable2nasdfasdfasfdo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                                            ),
                                        //new TimedTransition(7500, "AttackDone"),
                                        new TimedTransition(13500, "AttackDone")
        #endregion
        #region MinionToss
                                        ),
                                    new State("MinionToss",
                                        new HpLessTransition(0.060, "AllIn"),
                                        new StayCloseToSpawn(0.6, 5),
                                        new Wander(0.6),
                                        new Shoot(8.5, 2, predictive: 0.5, coolDown: 1000, projectileIndex: 2, shootAngle: 180),
                                        new Shoot(8.5, 1, predictive: 0.5, coolDown: 1000, projectileIndex: 2),
                                        new Shoot(22, 4, coolDown: 2400, projectileIndex: 4),
                                        new State("minion_toss0oooo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TimedTransition(2000, "minion_toss1oooo")
                                            ),
                                        new State("minion_toss1oooo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TossObject("Minion of Oryx", 3, 30, 100000 * 1000),
                                            new TossObject("Minion of Oryx", 3, 180, 100000 * 1000),
                                            new TossObject("Assassin of Oryx", 3, 330, 100000 * 1000),
                                            new TimedTransition(400, "miniontoss2oooo")
                                            ),
                                        new State("miniontoss2oooo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TossObject("Minion of Oryx", 3, 120, 100000 * 1000),
                                            new TossObject("Minion of Oryx", 3, 260, 100000 * 1000),
                                            new TossObject("Assassin of Oryx", 3, 40, 100000 * 1000),
                                            new TimedTransition(400, "miniontoss3oooo")
                                            ),
                                        new State("miniontoss3oooo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TossObject("Minion of Oryx", 6, 210, 100000 * 1000),
                                            new TossObject("Minion of Oryx", 6, 300, 100000 * 1000),
                                            new TossObject("Assassin of Oryx", 6, 120, 100000 * 1000),
                                            new TimedTransition(400, "minion_toss4oooo")
                                            ),
                                        new State("minion_toss4oooo",
                                            new TossObject("Minion of Oryx", 11, 0, 100000 * 1000),
                                            new TossObject("Minion of Oryx", 11, 120, 100000 * 1000),
                                            new TossObject("Assassin of Oryx", 11, 240, 100000 * 1000),
                                            new TimedTransition(400, "watch_the_kids_playoooo")
                                            ),
                                        new State("watch_the_kids_playoooo",
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable)
                                            ),
                                        new TimedTransition(15000, "AttackDone")
        #endregion
        #region BulletDance
                                        ),
                                    new State("BulletDance",
                                        new HpLessTransition(0.060, "AllIn"),
                                        new State("set_up_the_ringtwrewetrwtre",
                                            new RemoveEntity(50, "Minion of Oryx"),
                                            new RemoveEntity(50, "Assassin of Oryx"),
                                            new Taunt(1.0, true, "Time for more dancing! Hahahaha!!"),
                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                            new TossObject("Ring Element", 8.0, 0, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 24, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 48, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 72, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 96, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 120, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 144, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 168, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 192, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 216, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 240, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 264, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 288, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 312, 10000 * 1000),
                                            new TossObject("Ring Element", 8.0, 336, 10000 * 1000),
                                            new State("antispectator1fag333",
                                                new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                                new TimedTransition(500, "antispectator2fag333")
                                                ),
                                            new State("antispectator2fag333",
                                                new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                                new TimedTransition(500, "antispectator3fag333")
                                                ),
                                            new State("antispectator3fag333",
                                                new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000),
                                                new TimedTransition(500, "antispectator4fag333")
                                                ),
                                            new State("antispectator4fag333",
                                                new Spawn("Anti-Spectator", 4, 0.25, coolDown: 90000)
                                                ),
                                            new TimedTransition(2000, "grenade1b333")
                                            ),
                                        new State("grenade1b333",
                                            new Grenade(2.5, 220, 4.5, 60, coolDown: 90000),
                                            new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 0),
                                            new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 45),
                                            new TimedTransition(700, "grenade2b333")
                                            ),
                                        new State("grenade2b333",
                                            new Grenade(2.5, 220, 4.5, 240, coolDown: 90000),
                                            new State("Attack333",
                                                new Shoot(14, coolDownOffset: 0, count: 36, coolDown: 90000, projectileIndex: 11, shootAngle: 10, fixedAngle: 0),
                                                new Shoot(14, coolDownOffset: 500, count: 36, coolDown: 90000, projectileIndex: 12, shootAngle: 10, fixedAngle: 5),
                                                new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 7.5),
                                                new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 52.5),
                                                new Shoot(14, 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 75),
                                                new TimedTransition(700, "grenade3b333")
                                                ),
                                            new State("grenade3b333",
                                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                new Grenade(2.5, 220, 4.5, 0, coolDown: 90000),
                                                new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 15),
                                                new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 60),
                                                new TimedTransition(700, "grenade4b333")
                                                ),
                                            new State("grenade4b333",
                                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                new Grenade(2.5, 220, 4.5, 180, coolDown: 90000),
                                                new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 22.5),
                                                new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 67.5),
                                                new Shoot(14, 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 90),
                                                new TimedTransition(700, "grenade5b333")
                                                ),
                                            new State("grenade5b333",
                                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                new Grenade(2.5, 220, 4.5, 180, coolDown: 90000),
                                                new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 30),
                                                new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 75),
                                                new TimedTransition(700, "grenade6b333")
                                                ),
                                            new State("grenade6b333",
                                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                new Grenade(2.5, 220, 4.5, 180, coolDown: 90000),
                                                new Shoot(14, coolDownOffset: 200, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 37.5),
                                                new Shoot(14, coolDownOffset: 600, count: 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 82.5),
                                                new Shoot(14, 4, coolDown: 350, projectileIndex: 10, shootAngle: 90, fixedAngle: 105),
                                                new TimedTransition(700, "grenade1b333")
                                                ),
                                            new TimedTransition(21000, "AttackDone")
        #endregion
        #region ShieldCycle
                                            ),
                                        new State("shieldCycleasdfasdfasdf",
                                            new State("invulnerable9999999999999999999999999999999999999999999",
                                                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                new TimedTransition(3600, "vulnerable999999999999999999999999999999")
                                                ),
                                            new State("vulnerable999999999999999999999999999999",
                                                new TimedTransition(1000, "invulnerable9999999999999999999999999999999999999999999")
        #endregion
        #region ShieldCycle2
                                                ),
                                            new State("shieldCycle2asdfasdfasdf",
                                                new State("invulnerable2661234698712938764986123984986123987489762189734",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new TimedTransition(1400, "vulnerable123490216341798")
                                                    ),
                                                new State("vulnerable123490216341798",
                                                    new TimedTransition(1400, "invulnerable123412341234123412")
                                                    ),
                                                new State("invulnerable123412341234123412",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new TimedTransition(2200, "invulnerable2661234698712938764986123984986123987489762189734")
        #endregion
        #region ShieldCycle3
                                                    ),
                                            new State("shieldCycle3asdfasdfasdf",
                                                new State("invulnerableborkisafaggot",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new TimedTransition(1600, "vulnerabledevwarltiscool")
                                                    ),
                                                new State("vulnerabledevwarltiscool",
                                                    new TimedTransition(800, "invulnerablearcanuohasabigdick")
                                                    ),
                                                new State("invulnerablearcanuohasabigdick",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new TimedTransition(1600, "invulnerableborkisafaggot")
                                                    )
        #endregion
        #region ChaseCourse
                                                ),
                                            new State("ChaseCourse",
                                                new HpLessTransition(0.060, "AllIn"),
                                                new State("Ini....",
                                                    new RemoveEntity(50, "Minion of Oryx"),
                                                    new RemoveEntity(50, "Assassin of Oryx"),
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new StayCloseToSpawn(1, 0),
                                                    new Taunt(1.0, true, "FOOL! Flee while you can!!!", "You shall never see the light of day!", "Yes, run for your worthless lives!!!", "You WILL flear me!!!"),
                                                    new TimedTransition(1600, "ThrowStuff....")
                                                    ),
                                                new State("ThrowStuff....",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new Spawn("Chase Element", 1, coolDown: 1000 * 1000),
                                                    new TossObject("Chase Element", 8, 0, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 8, 90, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 8, 180, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 8, 270, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 11, 45, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 11, 135, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 11, 225, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 11, 315, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 16, 0, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 16, 90, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 16, 180, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 16, 270, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 22, 45, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 22, 135, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 22, 225, coolDown: 10000 * 1000),
                                                    new TossObject("Chase Element", 22, 315, coolDown: 10000 * 1000),
                                                    new TimedTransition(2000, "Tag....")
                                                    ),
                                                new State("Tag....",
                                                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                    new TimedTransition(200, "Chase9999....")
                                                    ),
                                                new State("Chase9999....",
                                                    new State("shieldCycle....",
                                                        new State("invulnerableqwer....",
                                                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                            new TimedTransition(3600, "vulnerableqwer....")
                                                            ),
                                                        new State("vulnerableqwer....",
                                                        new TimedTransition(1000, "invulnerableqwer....")
                                                            ),
                                                        new StayCloseToSpawn(1.6, 23),
                                                        new Charge(1.2, 10, 0),
                                                        new Shoot(14, coolDownOffset: 200, predictive: 1, count: 5, coolDown: 2000, projectileIndex: 16, shootAngle: 25, defaultAngle: 0),
                                                        new Shoot(14, coolDownOffset: 600, count: 2, coolDown: 1200, projectileIndex: 15, shootAngle: 30, defaultAngle: 0),
                                                        new Shoot(14, coolDownOffset: 1200, count: 3, coolDown: 1200, projectileIndex: 15, shootAngle: 20, defaultAngle: 0),
                                                        new TimedTransition(20000, "Chase9999....")
                                                        ),
                                                    new State("Return....",
                                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                        new Taunt(0.7, true, "Enough games!"),
                                                        new StayCloseToSpawn(0.8, 3)
                                                        ),
                                                    new TimedTransition(25000, "AttackDone")
        #endregion
        #region Orbitals
                                                    ),
                                                new State("Orbitals",
                                                    new HpLessTransition(0.060, "AllIn"),
                                                    new State("shieldCycle,,,,",
                                                        new RemoveEntity(50, "Minion of Oryx"),
                                                        new RemoveEntity(50, "Assassin of Oryx"),
                                                        new Taunt(1.0, true, "Tremble before my cosmic might!!!"),
                                                        new TossObject("Black Planet", 9.5, 0, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 45, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 90, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 135, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 180, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 225, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 270, coolDown: 10000 * 1000),
                                                        new TossObject("Black Planet", 9.5, 315, coolDown: 10000 * 1000),
                                                        new State("invulnerableaaa,,,,",
                                                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                                                        new TimedTransition(3600, "vulnerableaaa,,,,")
                                                        ),
                                                    new State("vulnerableaaa,,,,",
                                                        new TimedTransition(1000, "invulnerableaaa,,,,")
                                                        ),
                                                    new Shoot(14, coolDownOffset: 400, count: 3, coolDown: 1000, projectileIndex: 13, shootAngle: 120, defaultAngle: 0),
                                                    new Shoot(14, coolDownOffset: 1200, count: 3, coolDown: 1000, projectileIndex: 14, shootAngle: 120, defaultAngle: 0),
                                                    new Shoot(14, coolDownOffset: 4000, count: 10, coolDown: 5200, projectileIndex: 17, shootAngle: 36, defaultAngle: 0),
                                                    new Shoot(14, coolDownOffset: 4600, count: 10, coolDown: 5200, projectileIndex: 17, shootAngle: 36, defaultAngle: 18),
                                                    new TimedTransition(23000, "AttackDone")
        #endregion
        #region Gayass symbols
                                                                )
                                                            )   
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    )
                )
            )
        );
    }
}
#endregion
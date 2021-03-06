﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

/*
 *  Author: Mike
 *  
 *  Production Grand Sphinx Behavior
 *  
 *  ToS:
 *  MUST give credits if you use this behavior.
 * 
 * */

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Encounters = () => Behav()
        .Init("Grand Sphinx",
            new State(
                new DropPortalOnDeath("Tomb of the Ancients Portal", 20, PortalDespawnTimeSec: 45),
                new StayCloseToSpawn(0.55, 12),
                new Wander(0.55),
                new Spawn("Horrid Reaper", maxChildren: 6),
                new State("start_the_fun",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new PlayerWithinTransition(11, "Warning0")
                    ),
                new State("Warning0",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new Flash(0x00FF00, 0.2, 10),
                    new TimedTransition(2000, "flame_on")
                    ),
                new State("flame_on",
                    new Shoot(20, 3, projectileIndex: 0, coolDown: 600, predictive: 0.4, shootAngle: 30),
                    new Shoot(20, 3, projectileIndex: 0, coolDown: 600, predictive: 0.4, shootAngle: 120, angleOffset: 0.3),
                    new TimedTransition(7000, "Warning")
                    ),
                new State("Warning",
                    new Taunt(1.00, "You hide like cowards... but you can't hide from this!"),
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new Flash(0x00FF00, 0.2, 15),
                    new TimedTransition(3000, "dead_zed")
                    ),
                new State("dead_zed",
                    new State("dead_zed1",
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 40, projectileIndex: 1),
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 220, projectileIndex: 1),
                        new TimedTransition(1000, "dead_zed2")
                        ),
                    new State("dead_zed2",
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 80, projectileIndex: 1),
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 260, projectileIndex: 1),
                        new TimedTransition(1000, "dead_zed3")
                        ),
                    new State("dead_zed3",
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 120, projectileIndex: 1),
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 320, projectileIndex: 1),
                        new TimedTransition(1000, "dead_zed4")
                        ),
                    new State("dead_zed4",
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 160, projectileIndex: 1),
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 360, projectileIndex: 1),
                        new TimedTransition(1000, "dead_zed5")
                        ),
                    new State("dead_zed5",
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 200, projectileIndex: 1),
                        new Shoot(10, 11, 7, coolDown: 1600, fixedAngle: 40, projectileIndex: 1),
                        new TimedTransition(1000, "dead_zed1")
                        ),
                    new TimedTransition(8000, "Warning2")
                    ),
                new State("Warning2",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new Flash(0x00FF00, 0.2, 15),
                    new TimedTransition(3000, "burn_baby_burn")
                    ),
                new State("burn_baby_burn",
                    new Shoot(10, 2, 10, coolDown: 2000, coolDownOffset: 0, projectileIndex: 2),
                    new Shoot(10, 2, 10, coolDown: 2000, coolDownOffset: 500, projectileIndex: 2),
                    new Shoot(10, 9, 40, coolDown: 2000, fixedAngle: 20, angleOffset: 1, projectileIndex: 2),
                    new Shoot(10, 2, 10, coolDown: 2000, coolDownOffset: 1500, projectileIndex: 2),
                    new Shoot(10, 2, 10, coolDown: 2000, coolDownOffset: 2, projectileIndex: 2),
                    new Shoot(10, 8, 10, coolDown: 2000, coolDownOffset: 2500, projectileIndex: 2),
                    new TimedTransition(7600, "Warning0"),
                    new HpLessTransition(0.2, "no_more_reaper")
                    ),
                new State("no_more_reaper",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new Order(50, "Horrid Reaper", "quick_die"),
                    new TimedTransition(3000, "flame_on")
                )
            ),
            new Threshold(.02,
                new ItemLoot("Potion of Vitality", .12)
                ),
            new Threshold(.15,
                new ItemLoot("Potion of Wisdom", .2)
                ),
            new Threshold(.075,
                new ItemLoot("Helm of the Juggernaut", .002)
                )
        )
        .Init("Horrid Reaper",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                new State("break_time",
                    new Protect(1, "Grand Sphinx", 18, 10, 10),
                    new Wander(3),
                    new TimedTransition(2000, "slow_follow")
                    ),
                new State("slow_follow",
                    new Protect(1, "Grand Sphinx", 18, 10, 10),
                    new Follow(0.5, 10, 2.5),
                    new Shoot(10, 1, projectileIndex: 1, coolDown: 400, predictive: 0.4, coolDownOffset: 600),
                    new TimedTransition(4500, "fast_follow")
                    ),
                new State("fast_follow",
                    new Protect(1, "Grand Sphinx", 18, 10, 10),
                    new Follow(0.8, 10, 2.5),
                    new Shoot(10, 1, projectileIndex: 0, coolDown: 200, predictive: 0.4, coolDownOffset: 400),
                    new TimedTransition(3000, "break_time2")
                    ),
                new State("break_time2",
                    new Protect(1, "Grand Sphinx", 18, 10, 10),
                    new Wander(3),
                    new TimedTransition(3500, "splash_damage")
                    ),
                new State("splash_damage",
                    new Shoot(10, 6, projectileIndex: 0, coolDown: 600, shootAngle: 60),
                    new TimedTransition(6500, "slow_follow"),
                    new EntityNotExistsTransition("Grand Sphinx", 50, "die")
                    ),
                new State("die",
                    new Decay(0)
                    ),
                new State("quick_die",
                    new Taunt("OOaoaoAaAoaAAOOAoaaoooaa!!!"),
                    new Decay(1000)
                    )
                )
        );
    }
}

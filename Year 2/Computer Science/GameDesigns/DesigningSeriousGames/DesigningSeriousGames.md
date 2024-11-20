# Design Serious Games

<details>

<summary>Table Of Content</summary>

- [Design Serious Games](#design-serious-games)
  - [Introduction to Game Development](#introduction-to-game-development)
    - [Theme: Climate Change](#theme-climate-change)
  - [Lesson 1: Introduction to Game Development](#lesson-1-introduction-to-game-development)
    - [Instructor](#instructor)
    - [Course Outline](#course-outline)
    - [Game Development Pipeline](#game-development-pipeline)
    - [Game Design Basics](#game-design-basics)
    - [Roles in Game Development](#roles-in-game-development)
    - [Types and Genres of Games](#types-and-genres-of-games)
    - [Essential Skills for Game Designers](#essential-skills-for-game-designers)
    - [Game Development Stages](#game-development-stages)
    - [Key Takeaways](#key-takeaways)
  - [Lesson 2: Serious Games, Game Design Theory](#lesson-2-serious-games-game-design-theory)
    - [What is a Serious Game?](#what-is-a-serious-game)
    - [Theory of Fun in Game Design](#theory-of-fun-in-game-design)
    - [Game Analysis and Design](#game-analysis-and-design)
    - [The Three Cs of Game Design](#the-three-cs-of-game-design)
    - [Core Game Loops](#core-game-loops)
    - [Emotional Triggers and Immersion](#emotional-triggers-and-immersion)
    - [Game Experience and Player Emotions](#game-experience-and-player-emotions)
    - [Game Feel and Atmosphere](#game-feel-and-atmosphere)
    - [Goals, Decisions, and Interactivity](#goals-decisions-and-interactivity)
    - [Interface and Information](#interface-and-information)
    - [Summary](#summary)
    - [Resources for Further Study](#resources-for-further-study)
  - [Lesson 3: From Idea to Concept](#lesson-3-from-idea-to-concept)
    - [Discussing Climate Change](#discussing-climate-change)
    - [Serious Game Ideas on Climate Change](#serious-game-ideas-on-climate-change)
    - [Game Themes and Thematic Axis](#game-themes-and-thematic-axis)
    - [Game Design Documents \& Tools](#game-design-documents--tools)
    - [Key Elements of the One-Sheet Document](#key-elements-of-the-one-sheet-document)
    - [Ten-Page Design Document Structure](#ten-page-design-document-structure)
    - [The High-Level Design Document](#the-high-level-design-document)
    - [The Beat Chart](#the-beat-chart)
    - [The Full Game Design Document (GDD)](#the-full-game-design-document-gdd)
    - [Content Documents](#content-documents)
    - [Tools for Game Design](#tools-for-game-design)
    - [Developing a Game Concept](#developing-a-game-concept)
    - [The Pitch Deck](#the-pitch-deck)
    - [Player Types and Demographics](#player-types-and-demographics)
    - [Resources](#resources)
    - [Game Brainstorming Workshop](#game-brainstorming-workshop)
  - [Lesson 4: Mechanics, Verbs, Systems](#lesson-4-mechanics-verbs-systems)
    - [Game Mechanics](#game-mechanics)
    - [Key Aspects of Mechanics](#key-aspects-of-mechanics)
    - [Core Mechanics in Game Genres](#core-mechanics-in-game-genres)
    - [Verbs in Games](#verbs-in-games)
    - [MDA Framework: Mechanics, Dynamics, Aesthetics](#mda-framework-mechanics-dynamics-aesthetics)
    - [Feedback Loops](#feedback-loops)
    - [Emergence in Gameplay](#emergence-in-gameplay)
    - [Prototyping and Testing](#prototyping-and-testing)
    - [Resources](#resources-1)
  - [Lesson 5: Pitch Your Game Workshop (and more)](#lesson-5-pitch-your-game-workshop-and-more)
    - [Pitch Your Game Workshop](#pitch-your-game-workshop)
    - [Game Development as an Iterative Process](#game-development-as-an-iterative-process)
    - [Game Usability Testing \& Playtesting](#game-usability-testing--playtesting)
    - [Heuristic Evaluation](#heuristic-evaluation)
    - [Expert Reviews](#expert-reviews)
    - [Eye Tracking Testing](#eye-tracking-testing)
    - [AI Testing \& Game Analytics](#ai-testing--game-analytics)
    - [Usability Labs](#usability-labs)
    - [Playtesting Primer](#playtesting-primer)
    - [A Brief History of Sound in Video Games](#a-brief-history-of-sound-in-video-games)
    - [The Role of Audio in Game Design](#the-role-of-audio-in-game-design)
    - [Game Soundscapes](#game-soundscapes)
    - [The Role of Music in Video Games](#the-role-of-music-in-video-games)
    - [Dynamic Music and Ambient Sound](#dynamic-music-and-ambient-sound)
    - [Audio Prioritization and Sound Quality](#audio-prioritization-and-sound-quality)
    - [The Developer / Musician Relationship](#the-developer--musician-relationship)
    - [Key Musical Terminology](#key-musical-terminology)
    - [Additional Resources](#additional-resources)
  - [Lesson 6: Level Design](#lesson-6-level-design)
    - [Overview](#overview)
    - [Role of the Level Designer](#role-of-the-level-designer)
    - [Goals of Good Level Design](#goals-of-good-level-design)
    - [Practical Rules for Level Design](#practical-rules-for-level-design)
    - [Flow and Difficulty](#flow-and-difficulty)
      - [Example: Mario’s Level 1-1](#example-marios-level-1-1)
      - [Example: Doom's Design Elements](#example-dooms-design-elements)
    - [Types of Level Design](#types-of-level-design)
    - [Teaching, Testing, and Rewarding in Level Design](#teaching-testing-and-rewarding-in-level-design)
    - [Visuals in Game Design](#visuals-in-game-design)
    - [Visual Composition](#visual-composition)
    - [Traditional Level Design Pipeline](#traditional-level-design-pipeline)
    - [3D Level Design Considerations](#3d-level-design-considerations)
    - [Starting a New Level](#starting-a-new-level)
    - [Level Characteristics](#level-characteristics)
  - [Lesson 7: Interact Narrative \& Storytelling](#lesson-7-interact-narrative--storytelling)
    - [Storytelling Basics](#storytelling-basics)
    - [Influential Works on Story Structure](#influential-works-on-story-structure)
    - [Types of Story Structures](#types-of-story-structures)
    - [Narrative Elements](#narrative-elements)
    - [Video Game Narratives](#video-game-narratives)
    - [Types of Game Narratives](#types-of-game-narratives)
    - [Narrative Design](#narrative-design)
    - [Interactive \& Dynamic Writing](#interactive--dynamic-writing)
    - [World Building](#world-building)
    - [Environment Design](#environment-design)
    - [Narrative Tools for Game Development](#narrative-tools-for-game-development)
    - [Resources \& Further Reading](#resources--further-reading)

</details>

## Introduction to Game Development

game idea -> game concept -> initial documentation and final game idea \
Prototype -> pitch -> demo and/vertical slice \
Testing & iterating -> Final Game

Our team has to design, code and produce a full serious game using Godot. \
Small but polished game, following rules of game design and dev \
The deliverable has to be a pleasing serious game, and be as bug free and as feature complete as possible.

### Theme: Climate Change

subject nuclear power, effects of the raise of the ocean atmospheric temperature, mobility options, wildfires

## Lesson 1: Introduction to Game Development

### Instructor

- **Konstantinos Dimopoulos**: Game designer, urbanist, author, and educator with experience in urban planning and game design.
  - **Published Works**: *Virtual Cities*, contributions to *Game Writing 2nd Edition*, *Virtual Interiorities*, and *The Architectronics of Game Spaces*.
  - **Games Worked On**: *ARMA Reforger*, *The Sinking City*, *Crime Boss: Rockay City*, *Lake*, *A Place for the Unwilling*, *Seed*, *Dream City Knights*, *Droidscape: Basilica*, and *Ex Novo*.

### Course Outline

- **Weekly Schedule**:
  - **Week 1**:
    - **Monday**: Introduction to Game Development, GODOT 4.3 Workshop.
    - **Tuesday**: Game Design Theory and Serious Games.
    - **Wednesday**: From Idea to Concept, Brainstorming Workshop.
    - **Thursday**: Mechanics, Verbs, Systems, Prototype Workshop.
    - **Friday**: Game Music, Game Testing, and Pitch Your Game Presentation.
    - **End of Week Deliverable**: A pitch deck.
  - **Week 2**:
    - **Tuesday**: Level Design with Mari0 Workshop.
    - **Wednesday**: Interactive Narrative & Storytelling, Twine Workshop.
    - **Thursday**: Gamification, Analysis and Design Workshops.
    - **Friday**: UI, UX, Game Economies Workshop.
  - **Final Weeks**: Remote meetings, project work, and final game delivery in Week 7.
- **Final Project**: Develop a serious game using the GODOT 4.3 engine with a **theme of climate change**.
  - Teams can choose specific topics like nuclear power, rising temperatures, mobility, or wildfires, and genres such as strategy, trivia, or platformer.

### Game Development Pipeline

- **Stages of Development**:
  1. **Game Idea**: Initial brainstorming of concepts.
  2. **Game Concept**: Develop ideas into concrete concepts with initial documentation.
  3. **Prototype**: Early development for testing core mechanics and gameplay.
  4. **Pitch**: Present the concept to gain feedback and iterate.
  5. **Demo or Vertical Slice**: A sample of polished gameplay for further testing.
  6. **Testing & Iterating**: Continuous testing to refine features and fix bugs.
  7. **Final Game**: Complete, polished, feature-complete, and bug-free version.

### Game Design Basics

- **Defining a Game**:
  - **"A game is an artificial system for generating experiences"** - Tynan Sylvester, *RimWorld*.
  - **"Games are a series of interesting decisions"** - Sid Meier, *Civilization*.
  - **Core Elements**: Fiction (framing, plot, setting) and Mechanics (rules, systems).
  - **Goal of Design**: Achieve harmony between fiction and mechanics to elicit player emotions and engagement.
  
- **Game Engines**:
  - **GODOT 4.3**:
    - Open-source, lightweight, and supports both 2D and 3D game development.
    - Platform Compatibility: Deploy to mobile, web, personal computers, and consoles.
    - **GDScript**: A Python-like language optimized for GODOT, ideal for quick development.
    - **Community**: Large support base with rich documentation and resources.

### Roles in Game Development

- **Game Designer**: Defines mechanics, systems, game structure, and player experience.
- **Types of Designers**:
  - **Content Designer**: Creates plot points, worlds, characters, and lore.
  - **Level Designer**: Designs spaces and levels; organizes game flow and structure.
  - **Systems Designer**: Balances systems and mechanics, including stats and economies.
  - **Experience Designer**: Focuses on audiovisual feedback and feel of the game.
  - **Narrative Designer**: Integrates storytelling with gameplay mechanics.
- **Other Roles**: Includes generalist programmers, AI and graphics specialists, audio engineers, QA, UI/UX designers, marketers, and producers.

### Types and Genres of Games

- **Game Genres**: Platformers, RPGs, simulators, puzzle games, real-time strategy, horror, immersive sims, etc.
- **Story Genres**: Includes themes like crime, fantasy, sci-fi, historical drama, horror, and romance.
- **Game Types**: Differentiate based on gameplay mechanics and player experience, such as narrative-driven, open-world, sandbox, or puzzle.

### Essential Skills for Game Designers

- **Communication**: Vital for collaborating across teams.
- **Adaptability**: Must learn new tools, understand project needs, and embrace feedback.
- **Tolerance for Feedback**: Willingness to accept criticism and adapt accordingly.
- **Learning Skills**: Ability to quickly acquire new knowledge is crucial for ongoing improvement.
- **Setting Realistic Goals**: Knowing when to cut content or features to meet project goals.

### Game Development Stages

1. **Pre-Production**:
   - Define the scope, concept, platform, budget, timeline, and core mechanics.
   - **Game Design Document**: Formal documentation of game vision, systems, and objectives.
   - Develop initial prototypes and conduct technical tests.
2. **Production**:
   - **Programming**: Implement core mechanics and systems.
   - **Asset Creation**: Develop graphics, audio, and other assets.
   - **Content Creation**: Create levels, narrative elements, and in-game assets.
   - **Testing and Iteration**: Regular testing to improve and refine gameplay.
3. **Post-Production**:
   - **Updates & Patches**: Fix bugs and add enhancements.
   - **DLC and Expansions**: Add new content to extend the game's lifecycle.
   - **Postmortem**: Review project successes and areas for improvement.

### Key Takeaways

- **Game Development is Collaborative**: Requires diverse skills and teamwork from all project members.
- **Iterative Process**: Continuous testing and feedback loops are essential for a polished final product.
- **Player-Centered Design**: The ultimate aim is to craft a cohesive experience that engages and immerses players.

---

## Lesson 2: Serious Games, Game Design Theory

### What is a Serious Game?

- **Definition**: A serious game is designed for purposes beyond entertainment, used in education, healthcare, city planning, emergency management, and more.
- **Key Elements**:
  - **Purpose**: Each game has a clear, serious purpose, such as education or training.
  - **Engagement**: Must be enjoyable to play, even as it serves a real-world function.
  - **Historical Example**: *The Landlord’s Game* (early form of Monopoly) is an example of an early serious game focused on economic and social issues.

### Theory of Fun in Game Design

- **Pattern Recognition**: Games engage the brain by offering patterns to recognize and master.
- **Adaptation and Boredom**: Games become boring when players master patterns and no new challenges remain.
- **Brain Exercise**: Games are powerful tools for improving skills like problem-solving, strategy, and hand-eye coordination.

### Game Analysis and Design

- **Analyzing Games**:
  - **Playability**: Is the game approachable and easy to understand? Are controls intuitive?
  - **Core Gameplay Loop**: Identifies the main actions that players repeat. Examples include "run, jump, avoid" for *Super Mario Bros.*
  - **Aesthetics**: The visual and auditory appeal of a game and its alignment with themes.
  - **Longevity**: Does the game maintain interest over time? Is it replayable?

- **Mechanics vs. Fiction**:
  - Games require a balance of mechanics (rules, actions) and fiction (story, setting).
  - Mechanics can drive engagement and immersion, while fiction adds context and meaning.
  - Examples include the layered systems in *Bioshock* and immersive storytelling in *Half-Life 2*.

### The Three Cs of Game Design

1. **Character**: Defines who the player embodies in the game.
2. **Camera**: Dictates the player’s visual perspective, e.g., first-person, third-person.
3. **Control**: Describes how the player interacts with the game, focusing on responsiveness and relevance to the game’s theme.

### Core Game Loops

- **Definition**: The main actions repeated throughout the game, essential to structure and pacing.
- **Examples**:
  - *Battlefield*: Target, aim, shoot, seek new enemies.
  - *Pac-Man*: Navigate maze, avoid ghosts, collect dots.
- **Rewards**: Immediate feedback, often through action and reaction, satisfies player engagement.

### Emotional Triggers and Immersion

- **Emotional Triggers**: Actions or visuals that invoke emotions, such as challenges, rewards, or changes in state.
- **Suspension of Disbelief**: A state where players willingly accept the game world as real, enhancing immersion.
- **Immersion**: Games create immersive experiences through cohesive world-building, responsive interactions, and the alignment of player goals with in-game actions.

### Game Experience and Player Emotions

- **Experience Construction**: Every element in a game should contribute to a cohesive experience that aligns player actions, emotions, and character motivations.
- **Emotions in Gameplay**:
  - **Agency**: Players feel a sense of control and impact within the game world.
  - **Challenge and Mastery**: Overcoming difficult obstacles provides a sense of achievement.
- **Balancing Emotions**: Different types of games may evoke varied emotions, from tension and excitement to calmness and introspection.

### Game Feel and Atmosphere

- **Game Feel**: The immediate feedback of actions, like the impact of jumps, attacks, or collisions. Examples include screen shake effects and responsive controls.
- **Atmosphere**: Encompasses the emotional tone of a game, created through visuals, sound, and interactive elements.
- **Juxtaposition**: The blending of contrasting emotions, e.g., dark, intense settings with moments of calm.

### Goals, Decisions, and Interactivity

- **Game Goals**: Organized as primary/secondary, mandatory/optional, or progression-based.
- **Decision-Making**:
  - Players continuously make decisions, from trivial to complex, which influence their game path and outcomes.
  - Interesting decisions have a balance of risk, reward, and information.
- **Meaningful Interactivity**: Ensures decisions feel impactful and significant, enhancing player engagement and satisfaction.

### Interface and Information

- **Information Management**: A well-designed interface gives players the necessary information for decision-making without overwhelming them.
- **Diegetic Interfaces**: Interface elements integrated within the game world itself, enhancing immersion.

### Summary

This lesson emphasizes that effective game design balances fiction with mechanics, engages players through meaningful decisions, and creates immersive experiences. Each design choice, from interface to core mechanics, shapes the player’s journey and emotional connection with the game.

---

### Resources for Further Study

- **Books**: *Designing Games* by Tynan Sylvester, *A Theory of Fun for Game Design* by Raph Koster, *The Art of Game Design* by Jesse Schell.
- **Online Resources**: *Extra Credits* (YouTube), *Game Maker’s Toolkit*, and *GDC Vault*.

---

## Lesson 3: From Idea to Concept

### Discussing Climate Change

- **Definition**: Long-term changes in temperatures and weather patterns. Historically natural, but since the 19th century, human activities—primarily fossil fuel burning—are the main cause.
- **Key Greenhouse Gases**: Carbon dioxide and methane.
- **Current Focus Areas**: Preservation of forests and sustainable energy production.
  
### Serious Game Ideas on Climate Change

- **Examples of Climate-Related Serious Games**:
  - *Fate of the World*: Simulation game focused on managing global resources.
  - *SimCity Edu: Pollution Challenge*: Teaches about pollution.
  - *EcoQuest: The Search for Cetus*: Environmental adventure game.
  - *Working With Water*: Educational game on water management.
- **Reminder**: Serious games should focus on game mechanics, not just storytelling.

### Game Themes and Thematic Axis

- **Game Theme**: The core idea or "axis" of the game (e.g., heroism, exploration, mystery, nature).
- **Influence**: The theme should affect every part of the game, including mechanics, visuals, music, UI, and narrative.

### Game Design Documents & Tools

- **Purpose of Game Design Documents (GDD)**:
  - **Memory**: Document key ideas.
  - **Communication**: Share concepts with the team.
  - **Creativity Structure**: Provide a framework for development.
- **Types of Game Design Documents**:
  - **One-Sheet**: Brief, single-page document outlining core game concept.
  - **Ten-Page Document**: A more detailed overview with a breakdown of story, gameplay, characters, and controls.
  - **High-Level Design Document**: Outlines game concept, mechanics, core gameplay, and key features.
  - **Full Game Design Document (GDD)**: Comprehensive description of all aspects of the game, including narrative, controls, UI, characters, levels, and monetization.

### Key Elements of the One-Sheet Document

- **Title**: Temporary or code name.
- **Platforms**: Intended launch platforms.
- **Monetization**: Revenue strategies (e.g., app stores, in-app purchases).
- **Target Audience**: Demographics and age rating.
- **Game Summary**: Brief plot, setting, and player role.
- **Game Outline**: Genre, key gameplay mechanics, goals, and challenges.
- **Unique Selling Points (USP)**: 5-7 points highlighting what makes the game unique.
- **Similar Games**: List of competitive or similar games.
- **Early Concept Art**: Visual sketches or logo ideas.

### Ten-Page Design Document Structure

1. **Cover Page**: Include graphic/logo, target platform, audience, shipping date.
2. **Story/Game Summary**: Outline main characters and setting.
3. **Characters and Controls**: Control map and protagonist details.
4. **Gameplay Overview**: Genre, core actions, flow, and mechanics.
5. **Gameplay Experience**: Desired player emotions and moods.
6. **Mechanics and Modes**: Detailed look at core mechanics.
7. **Enemies and Challenges**: Types of enemies and puzzles.
8. **Bonus Material**: Possible downloadable content.
9. **Monetization Strategy**: Revenue plans.

### The High-Level Design Document

- **Core Sections**:
  - **Product Overview**
  - **Core Concept**
  - **Story and Setting**
  - **Gameplay Description**
  - **Interface & Controls**
  - **Level Walkthroughs**
  - **Art, Sound, and Music Overview**
  - **Budget and Timeframe**

### The Beat Chart

- **Purpose**: Maps game structure to track patterns, color schemes, and gameplay progression.
- **Example**: Used in games like *Maximo: Ghosts to Glory*.

### The Full Game Design Document (GDD)

- **Content**: A GDD can include game summary, story, controls, camera details, metrics, core gameplay loop, character design, mechanics, rewards, progression, level design, monetization, etc.
- **Format**: Often a wiki or living document that allows for changes as the game evolves.

### Content Documents

- **Purpose**: Describe game content like missions, weapons, monsters, quests, etc.
- **Format**: Often spreadsheets with item statistics.

### Tools for Game Design

- **Design Document Sharing**: ClickUp, Google Drive, Microsoft Teams.
- **Art and Concept Tools**: Miro, Canva, Photoshop.
- **Moodboard Tools**: GIMP, Miro.

### Developing a Game Concept

- **Components of a Game Concept**:
  - **Core Idea**: A unique, engaging idea.
  - **Player Experience**: Desired player emotions and gameplay feel.
  - **Mechanics**: Actions, verbs, core gameplay loop.
  - **Goals and Challenges**: What players will strive to achieve.
  - **Progression and Variety**: Engaging and varied gameplay.
  - **Narrative**: Basic setting, plot, and characters.
  - **Art Style and Music**: Define the aesthetic and tone.
  - **Unique Selling Point (USP)**: What makes the game stand out.
  - **Monetization**: Revenue strategy.
  - **Target Audience**: Age, demographics, and gaming preferences.
  - **Production Constraints**: Time, budget, and platform limitations.

### The Pitch Deck

- **Content**:
  - **Introduction**: Brief game overview.
  - **Plot & Narrative**: Story highlights.
  - **Gameplay Showcase**: Core gameplay mechanics.
  - **Unique Selling Points**: Key elements that make the game unique.
  - **Team**: Backgrounds and roles.
  - **Budget & Timeline**: Financial and timeline considerations.
  - **Audience**: Target demographics.
  - **Visual Appeal**: Exciting visuals to engage investors or publishers.

### Player Types and Demographics

- **Richard Bartle’s Player Types**:
  - Useful for understanding player motivations, especially in MMOs.
- **Audience Characteristics**:
  - **Age**: 38% of gamers are 18-34, and 20% are under 18.
  - **Gender**: In the U.S., 45% of gamers are women.
  - **Global Trends**: Countries like China and Vietnam have high player engagement.
  
### Resources

- **Books**:
  - *Designing Games* by Tynan Sylvester.
- **Useful Links**:
  - Game ideas: [Reddit Game Ideas](https://www.reddit.com/r/gameideas/)
  - Core loop design: [GameAnalytics Blog](https://gameanalytics.com/blog/how-to-perfect-your-games-core-loop/)

### Game Brainstorming Workshop

1. **Phase 1**: Free association to explore initial ideas.
2. **Phase 2**: Narrow down ideas, focus on a clear concept.
3. **Phase 3**: Create a pitch deck presentation.

---

## Lesson 4: Mechanics, Verbs, Systems

### Game Mechanics

- **Core Mechanics**: The essential, repeated actions that define player behavior in a game (Salen & Zimmerman).
- **Definitions**:
  - **Robin Hunicke, Marc LeBlanc, Robert Zubek (MDA Framework)**: Mechanics are the actions, behaviors, and controls available to the player.
  - **Jesse Schell**: Mechanics define a game’s rules, player objectives, and interactions.
- **Examples**:
  - In *Monopoly*, players can buy unowned properties.
  - In *Command & Conquer*, players can select multiple units by dragging.
  - In *VVVVVV*, pressing X inverts gravity.

### Key Aspects of Mechanics

- **Questions Mechanics Answer**:
  - **How do I play?**
  - **What can I do in the game?**
- **Mechanics vs. Systems**:
  - **Mechanics**: Actions players can perform (e.g., jump).
  - **Systems**: How the game responds to mechanics (e.g., gravity, trampolines).
- **Elegance in Mechanics**: Efficient mechanics minimize player effort and maximize gameplay depth. Examples include the simplicity and depth of *Chess* and *Sensible Soccer*.

### Core Mechanics in Game Genres

- Core mechanics are fundamental to each genre:
  - *Shooting games*: Shooting.
  - *Adventure games*: Picking up and using items.
  - *Fighting games*: Attacking opponents.
  - *Match-3 games*: Matching tiles.

### Verbs in Games

- **Definition**: Verbs are the actions players can perform in a game, defining how they interact with the game world.
- **Examples**:
  - *DOOM*: Move, shoot, change weapon.
  - *Monkey Island*: Open, close, push, pull, talk to, pick up, etc.
  - *Text Adventures* (e.g., *Zork*): Offer a wide range of potential actions, creating an "analog" world illusion.

---

### MDA Framework: Mechanics, Dynamics, Aesthetics

- **Purpose**: Developed by Hunicke, LeBlanc, and Zubek to structure game analysis and design.
  - **Mechanics**: Game rules and actions players can take.
  - **Dynamics**: The flow and strategies emerging from mechanics.
  - **Aesthetics**: The player’s emotional response and experience.

- **8 Kinds of Fun (MDA)**:
  1. **Sensation** - Sensory pleasure.
  2. **Fantasy** - Make-believe experiences.
  3. **Narrative** - Story and drama.
  4. **Challenge** - Overcoming obstacles.
  5. **Fellowship** - Social interaction.
  6. **Discovery** - Exploration.
  7. **Expression** - Self-discovery.
  8. **Submission** - Immersive pastime.

### Feedback Loops

- **Positive Feedback Loops**: Reinforce success (e.g., more power-ups for high scores). May destabilize the game by widening player advantage.
- **Negative Feedback Loops**: Help balance gameplay by aiding players who fall behind (e.g., *Mario Kart*’s rubber-banding mechanics).
- **Usefulness**: Positive loops can end games quickly, while negative loops allow fair competition across skill levels.

### Emergence in Gameplay

- **Emergent Gameplay**: Complex situations arise from simple mechanics. Allows players to set unique goals and solve challenges creatively.
  - **Example**: *Speedrunning* as an emergent gameplay style.

### Prototyping and Testing

- **Purpose**: Prototypes help determine if a game concept is feasible and worth developing.
  - Focus on core mechanics and ignore aesthetics during initial prototyping.
  - **Paper Prototypes**: Quick, analog versions to test mechanics and iterate on design.

---

### Resources

- **Books**: *Rules of Play* by Tekinbas & Zimmerman, *The Art of Game Design* by Jesse Schell.
- **Further Reading**:
  - MDA Framework: [Read here](https://users.cs.northwestern.edu/~hunicke/MDA.pdf)
  - Emergent gameplay and mechanics development: *How Game Designers Create Meaningful Mechanics* on YouTube.
  - **Feedback Loops in Games**: Analyzing how positive and negative feedback loops affect gameplay in *Monopoly* and *Mario Kart*.

## Lesson 5: Pitch Your Game Workshop (and more)

### Pitch Your Game Workshop

- **Pitch Deck Requirements**:
  - **Introduction**
  - **Product Overview**
  - **Plot & Narrative**
  - **Gameplay Showcase**
  - **Unique Selling Points**
  - **Pithy Description**
  - **The Team**
  - **Budget & Timeline**
  - **Audience**
  - **Exciting Visuals**
- **Presentation Preparation**: Prepare a 5-10 minute presentation, ensuring all aspects are complete and visually appealing.

### Game Development as an Iterative Process

- **Game Testing / Playtesting**:
  - Essential for quality control and ensuring the mechanics, rules, and systems are understandable, engaging, and support the desired player experience.
  - **Types of Game Testing**:
    - Functional, Compatibility, Performance, Localization, Accessibility, Multiplayer/Singleplayer, Narrative, Stress, Alpha/Beta testing, QA, and many more.

### Game Usability Testing & Playtesting

- **Importance**: Usability testing and playtesting improve the game experience by providing real player feedback on prototypes and demos.
- **Key Elements to Observe**:
  - Player enjoyment, game progression, rhythm/flow, fairness, ease of learning, accessibility, and UI intuitiveness.
  
### Heuristic Evaluation

- **Purpose**: Experts use guidelines to identify design issues and improve player experience.
  - **Evaluation Criteria**:
    - Fun factor, game flow, fairness, learning curve, clarity of objectives, intuitive UI, minimalism, sound usage, and consistency in UI elements.

### Expert Reviews

- **Method**: Specialists (UI designers, game designers, etc.) play through the game to spot problems and recommend improvements.

### Eye Tracking Testing

- **Purpose**: Tracks where players focus, helping designers understand how players perceive the environment, notice objects, and interact with the UI.

### AI Testing & Game Analytics

- **AI Testing**: AI-driven testing solutions for detecting bugs and optimizing gameplay.
  - Example: [modl.ai](https://modl.ai/)
- **Game Analytics**: Tools to analyze player behavior.
  - Example: [GameAnalytics](https://gameanalytics.com/)

### Usability Labs

- **Description**: A controlled environment where users are observed interacting with a game. Observers track actions and gather insights on usability.

### Playtesting Primer

- **Playtesting Goals**:
  - Detect bugs, improve core gameplay, showcase dynamics, test interface, and refine player experience.
- **Guidelines for Effective Playtesting**:
  - Observe players’ behavior, listen to feedback without influencing responses, and focus on experiences over suggestions.

---

### A Brief History of Sound in Video Games

- Key titles and technologies that have shaped game audio:
  - **Pong (1972)** - Basic sound generator.
  - **Space Invaders (1978)** - Custom analog sound chip.
  - **Super Mario Bros. (1983)** - 8-bit NES sound chip.
  - **Ori and the Blind Forest (2015)** - Adaptive PCM sound.

### The Role of Audio in Game Design

- **Audio Cues**: Essential for feedback and enhancing game feel.
- **Types of Audio**:
  - **Level Soundtracks**: Dedicated themes for immersion.
  - **Dynamic Music**: Adapts to gameplay in real-time.
  - **Ambient Sounds**: Background noise to establish setting.
  - **SFX (Sound Effects)**: Impacts, interactions, movement sounds.
  - **Incidental Sounds**: Played during specific actions or events.
  
### Game Soundscapes

- **Definition**: All sounds in a game, including music, effects, and environmental sounds, creating the audible experience of gameplay.
- **Dynamic Music**: Changes based on game events (e.g., calm to combat music).
- **Categories of Sound Effects**:
  - **Local Sounds**: Play when close to the source.
  - **Distant Sounds**: Heard from afar, like explosions.
  - **Priority Sounds**: Play regardless of player location (e.g., health loss).

### The Role of Music in Video Games

- **Functions of Music**:
  - **Setting the Theme**: Establishes the game’s mood.
  - **Narration**: Enhances storytelling (e.g., *Journey*).
  - **Worldbuilding**: Defines game atmosphere (e.g., *GTA V*).
  - **Feedback**: Signals player progress and game events.
  - **Rhythm**: Guides pacing, especially in rhythm-based games like *Crypt of the Necrodancer*.
  
### Dynamic Music and Ambient Sound

- **Dynamic Score**: Music that adapts to gameplay moments (e.g., *Wing Commander*).
- **Ambient Sound**: Background sounds that enhance immersion and create a sense of place.

### Audio Prioritization and Sound Quality

- **Audio Hierarchy**: Not too many sounds at once; prioritize based on relevance to gameplay.
- **Bad Sound**: Disruptive or low-quality audio can significantly detract from the experience.

### The Developer / Musician Relationship

- **Collaboration Tips**:
  - Establish a temporary soundtrack, define the game’s mood and style, communicate needs clearly, and set realistic deadlines.

### Key Musical Terminology

- **Accent**: Emphasis on a beat.
- **Beat**: The pulse of the music.
- **Leitmotif**: A theme associated with specific characters or situations.

### Additional Resources

- **AI Tools for Sound Creation**: [SUNO AI](https://suno.com/create)
  
This lesson emphasizes the importance of a polished pitch deck, iterative testing, and the role of sound and music in creating a memorable gaming experience.

## Lesson 6: Level Design

### Overview

Level design is the applied and specialized branch of game design that translates abstract game rules into specific, playable experiences. It creates the environment and spaces that players explore, traverse, and play within. Effective level design integrates gameplay, environment, and storytelling while resolving technical issues (e.g., camera flipping) by using decorations or adjustments to improve player experience.

The term "level" can vary in scope, meaning anything from a mission or area to a world or quest, essentially describing the space where gameplay occurs.

### Role of the Level Designer

A level designer acts as an architect of virtual worlds, expressing game design within virtual space. They ensure players encounter challenges, puzzles, and opportunities, and are guided through the game’s narrative and key moments.

Level designers combine and arrange the work of the entire team, including textures, geometries, sprites, mechanics, music, sounds, enemies, hazards, and spawn points, to create a cohesive experience. Their responsibilities include:

- Placing and expressing:
  - Lighting
  - Characters
  - Enemies
  - Story elements
  - World-building elements
  - Core mechanics
- Ensuring the game vision becomes a playable reality.

### Goals of Good Level Design

Good level design should:

- Teach players the game’s mechanics
- Provide an entertaining experience
- Set appropriate difficulty and flow
- Reward or punish players as needed
- Enhance player immersion
- Offer variety and reward exploration
- Provide an engaging audiovisual experience
- Support and fulfill game design goals

### Practical Rules for Level Design

- **Form follows function**: Design elements should support functionality and usability.
- **Experience is key**: Design for emotional responses like delight, horror, and excitement.
- **Metrics matter**: Keep track of design measurements to maintain consistency.
- **Playtesting is mandatory**: Level design should be an iterative process.
- **Consider the player’s perspective**: Understand how players will see and experience the level.
- **Rhythm**: Create a balanced progression of challenge and rest.
- **Gradual introduction**: Introduce game elements and difficulty gradually.
- **Challenge and engagement**: Make spaces interesting and challenging.
- **References**: Gather inspiration from geology, urbanism, and architecture.

### Flow and Difficulty

Flow is the foundation of a successful gaming experience and applies to all genres. Breaks in flow can disrupt the player’s experience.

- **Goldilocks Zone of Flow**: The ideal flow state differs for each player and should match their skill level.
- **Elastic Challenges**: Provide different levels of success or failure (e.g., barely missing a jump but grabbing an edge).
- **Difficulty Options**: Dynamic difficulty adjustments can help match the challenge to player skill.

#### Example: Mario’s Level 1-1

The introductory level in *Super Mario Bros.* teaches:

- Breakable bricks
- Screen scrolling
- Power-ups (mushrooms)
- Enemy mechanics
- Basic controls and jumping

#### Example: Doom's Design Elements

- **Core gameplay elements**: FPS action, health and armor, weapons, monsters, and bonuses.
- **John Romero's Design Rules**:
  - Change floor height with texture changes
  - Use border textures between different wall segments
  - Align textures precisely
  - Use contrast in light and space
  - Ensure players can access visible areas
  - Include secret areas
  - Guide players through revisiting areas
  - Create recognizable landmarks for navigation

### Types of Level Design

- Varies by game genre, camera perspective, level size, game structure, and specific level purpose.
- Digital vs. analog level design.

### Teaching, Testing, and Rewarding in Level Design

- **Teaching**: Games must teach their rules and mechanics through safe environments, tutorials, or trial and error.
- **Testing**: Gradually increase the difficulty to test player skills.
- **Rewarding**: Provide rewards like points, powers, or achievements to reinforce positive player actions.

### Visuals in Game Design

A good level is functional, legible, and visually appealing. Visual complexity should be balanced to avoid overwhelming players with "visual noise." Establish a visual hierarchy to guide player attention, using clear visual symbols and consistent vocabulary for gameplay mechanics.

- **Level Design Tasks**:
  - Guiding players
  - Environmental storytelling
  - Filling empty spaces
  - Contributing to world-building
  - Emphasizing gameplay
  - Creating atmosphere

### Visual Composition

Effective visual composition arranges scene elements to guide the player’s gaze and creates aesthetically pleasing images. Techniques include:

- **Symmetry**
- **Rule of Thirds**
- **Guiding Lines**

### Traditional Level Design Pipeline

1. **Pre-Production**: Research, gather references, create level design documents, sketch and block out levels.
2. **Production**: Refine block-outs, add gameplay elements, test, sync audio and art.
3. **Iteration**: Final art and audio pass, lighting pass, and review.

### 3D Level Design Considerations

- Incorporate verticality and depth.
- Manage lines of sight carefully.
- Consider the challenges of 3D navigation and spatial awareness.
- Design AI to navigate 3D spaces effectively.

### Starting a New Level

Begin with a concept or inspiration. Consider the purpose, aesthetics, intended player experience, space, size, architecture, narrative, goals, and challenges.

### Level Characteristics

Key questions for level design:

- **What kind of space?** Describe the environment’s style and theme.
- **Size and duration**: How long will it take to explore or complete?
- **Paths**: What paths will players follow?
- **Aesthetics**: What visual and architectural styles are used?
- **Narrative**: What story does the level tell?
- **Goals and challenges**: What objectives will players face?

## Lesson 7: Interact Narrative & Storytelling

### Storytelling Basics

- **Elements of All Stories**:
  - Space and time, plot, characters, conflict, resolution, point of view, theme, and narrative style.
- **Story Arc**: A story's chronological path from beginning to end, often structured in three acts:
  1. **Beginning**: Inciting event sets the plot in motion.
  2. **Middle**: Protagonist faces challenges and attempts to overcome crises.
  3. **End**: Resolution or catharsis.

### Influential Works on Story Structure

- **Aristotle’s *Poetics***: Defines the three-act structure and cause-and-effect in storytelling.
- **Joseph Campbell’s *The Hero’s Journey***: A universal narrative pattern for the hero’s transformation journey, involving departure, initiation, and return.
- **Robert McKee’s *Story***: Emphasizes that stories revolve around transformation, obstacles, and scenes that contribute to change.

### Types of Story Structures

- **The Three-Act Structure**: Common in Western storytelling, focusing on setup, confrontation, and resolution.
- **Kishōtenketsu**: East Asian structure that does not rely on conflict, instead progressing through introduction, development, twist, and resolution.

---

### Narrative Elements

- **Theme**: The central idea or message of the story (e.g., love, freedom, sacrifice).
- **Plot**: The sequence of events or actions, usually involving escalating conflict.
- **Pace**: Varies throughout the story, starting fast, slowing in the middle, and intensifying at the climax.
- **Characters**: Characters should have depth, flaws, and be relatable or intriguing.
  - **Compelling Characters**: Defined by desires, beliefs, flaws, and unique traits.

### Video Game Narratives

- **Narrative vs. Story**: Narrative is how the story is presented; the story is the sequence of events.
- **Story Supporting Gameplay**: Story should enhance gameplay without alienating players uninterested in narratives.

### Types of Game Narratives

- **Linear Narrative**: Traditional storytelling with a fixed sequence.
- **Branching Narrative**: Players make choices that affect the story’s direction, though it can be costly to develop.
- **Parallel Paths**: Branches that converge at key points to reduce asset requirements.

### Narrative Design

- **Role**: Integrates story with game mechanics and level design to create a cohesive experience.
  - Aligns fiction with gameplay (e.g., the HUD in *Half-Life*).
  - Determines story elements like cutscenes, dialogue systems, and mandatory vs. optional content.

---

### Interactive & Dynamic Writing

- **Interactive Writing**: Crafting narratives that respond to player choices.
- **Dynamic Writing**: Story elements that adapt based on player actions (e.g., choices made in *Mass Effect*).

### World Building

- **Game World**: The setting where the game’s story unfolds, whether realistic, fantastical, or historical.
- **World Elements**:
  - **Map**: Geography, topography, and boundaries.
  - **Systems**: Rules for physics, magic, economics, politics, etc.
  - **Atmosphere and Theme**: Defines the world’s aesthetic and logic.

### Environment Design

- **Crafting Game Environments**:
  - **Gameplay Focused**: Every environment should enhance gameplay.
  - **Believable and Immersive**: Spaces should adhere to realistic or consistent rules (e.g., natural environments, settlements near water sources).
  - **Urban Environments**: Reflect real-world functions while supporting gameplay needs.

### Narrative Tools for Game Development

- **Interactive Storytelling Tools**:
  - [Twine](https://twinery.org/) - Interactive, non-linear stories.
  - [Arcweave](https://arcweave.com/) - Story mapping and narrative design.
  - [Articy Draft](https://www.articy.com/en/) - Professional narrative design tool.
  - [Ren’Py](https://www.renpy.org/) - Visual novels and interactive stories.
  - [Ink](https://www.inklestudios.com/ink/) - Script-based interactive storytelling.

---

### Resources & Further Reading

- **Books and Guides**:
  - *The Hero with a Thousand Faces* by Joseph Campbell
  - *Story: Substance, Structure, Style and the Principles of Screenwriting* by Robert McKee
- **Useful Articles**:
  - *Urban Design and the Creation of Videogame Cities* by Konstantinos Dimopoulos (Gamasutra)
- **Workshops and Tools**:
  - *Twine Workshop*: Create an interactive text-based adventure game.

---

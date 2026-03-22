namespace Portfolio.Services;

public static class Translations
{
    private static readonly Dictionary<LanguageService.Language, Dictionary<string, string>> _data = new()
    {
        [LanguageService.Language.EN] = new()
        {
            // NAV
            ["nav.home"] = "Home",
            ["nav.projects"] = "Projects",
            ["nav.about"] = "About Me",
            ["nav.contact"] = "Contact",

            // FOOTER
            ["footer.text"] = "Made by me ! ヾ(⌐■_■)ノ",

            // HOME — INTRO
            ["home.role"] = "Software Engineer",
            ["home.intro"] = "Hi, I'm Sébastien, a 26-year-old software engineer based in France with a master's degree in Computer Science, specialising in developing and managing software. Resourceful, creative, passionate about technology and agile management, with a taste for adventure and discovery — I am always looking for new challenges and opportunities to grow.",
            ["home.btn.projects"] = "View Projects",
            ["home.btn.contact"] = "Contact Me",
            ["home.marquee"] = "✦ DEVELOPER &nbsp;&nbsp;&nbsp; ✦ PROBLEM SOLVER &nbsp;&nbsp;&nbsp; ✦ OPEN TO OPPORTUNITIES &nbsp;&nbsp;&nbsp; ✦ SOFTWARE ENGINEER &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",

            // HOME — STATS
            ["home.stats.experience"] = "Years of Experience",
            ["home.stats.thousands"] = "THOUSANDS",
            ["home.stats.tickets"] = "Tickets solved",
            ["home.stats.tech"] = "Technologies Used",
            ["home.stats.toeic"] = "TOEIC SCORE",

            // HOME — EDUCATION
            ["home.education.title"] = "Education",
            ["home.edu.master.title"] = "Master in Computer Science",
            ["home.edu.master.school"] = "University of Lille",
            ["home.edu.master.desc"] = "Specialisation in Software Engineering. Graduated with honours. Master's thesis on the energy consumption of the development and use of IT solutions.",
            ["home.edu.master.tag1"] = "Graduated with honours",
            ["home.edu.master.tag2"] = "Software Engineering",
            ["home.edu.master.tag3"] = "Software management",
            ["home.edu.bachelor.title"] = "Bachelor's degree in Computer Science",
            ["home.edu.bachelor.school"] = "University of Lille",
            ["home.edu.bachelor.desc"] = "First year entirely done in English. General overview of computer science.",
            ["home.edu.bachelor.tag1"] = "Web Dev",
            ["home.edu.bachelor.tag2"] = "Network",
            ["home.edu.bachelor.tag3"] = "System Programming",
            ["home.edu.bachelor.tag4"] = "OOP Programming",
            ["home.edu.highschool.title"] = "High School Diploma",
            ["home.edu.highschool.school"] = "Lycée des Flandres",
            ["home.edu.highschool.desc"] = "High school diploma with a specialisation in science.",
            ["home.edu.highschool.tag1"] = "Graduated with high honours",

            // HOME — EXPERIENCE
            ["home.experience.title"] = "Work Experience",
            ["home.exp1.title"] = "C# (.NET) / Java Developer",
            ["home.exp1.period"] = "November 2022 – August 2025",
            ["home.exp1.desc"] = "I joined Ankama as part of the technical porting of the video game Dofus from Flash technology to the Unity game engine. In a team of 10 front-end developers, I developed new features, fixed bugs and optimised the performance of the game. I was also in charge of developing the new UIs and ensured code quality through numerous code reviews.",
            ["home.exp2.title"] = "Support Engineer",
            ["home.exp2.period"] = "September 2021 – September 2022",
            ["home.exp2.desc"] = "Integrated into the core of the supply chain, in the production department team, I implemented monitoring of the databases and applications used by the production countries. I set up visualisations of numerous KPIs according to the needs of different teams, and facilitated agile ceremonies. I also volunteered with the \"Sustainable Value Chain for Industry\" group to build a consumption-monitoring system for our software.",
            ["home.exp3.title"] = "C# Developer",
            ["home.exp3.period"] = "April 2021 – August 2021",
            ["home.exp3.desc"] = "I joined INRIA to support the technical development of a doctoral thesis focused on \"Interaction Techniques for Object Selection and Facial Expression Control in Virtual Reality\", supervised by two professors. My role was to gamify the experience and build a VR meeting scene where users could project documents, interact with objects, and collaborate across the network.",

            // HOME — SKILLS
            ["home.skills.title"] = "Skills",
            ["home.skills.technical"] = "Technical Skills",
            ["home.skills.tools"] = "Tools & Soft Skills",
            ["home.skill.agile"] = "Agile Methodology",
            ["home.skill.git"] = "Git",
            ["home.skill.cicd"] = "CI/CD Pipelines",
            ["home.skill.tracking"] = "Jira / Youtrack",
            ["home.skill.cloud"] = "Cloud Platforms",
            ["home.skill.architecture"] = "Software Architecture",
            ["home.skill.api"] = "REST / SOAP APIs",
            ["home.skill.uiux"] = "UI / UX",
            ["home.skill.documentation"] = "Technical Documentation",
            ["home.skill.codereview"] = "Code review",
            ["home.skill.communication"] = "Strong Communication & Empathy",

            // PROJECTS
            ["projects.hero.title"] = "My Projects",
            ["projects.hero.subtitle"] = "A curated selection of personal and professional work.",
            ["projects.featured.label"] = "Featured Project",
            ["projects.all.label"] = "All Projects",
            ["projects.featured.meta"] = "2020 — Video game",
            ["projects.featured.desc1"] = "My personal favourite, my game, is 100% handmade and homemade! From gameplay to sound, including the UIs and, of course, the programming. It's my first major personal project — a real challenge I set for myself during the COVID-19 lockdown. I finally had access to good hardware capable of running Unity, and plenty of time to put to good use.",
            ["projects.featured.desc2"] = "It allowed me to improve my development skills and understand the software development lifecycle. Although I worked alone, I got a taste of defining specifications, designing, deploying, and maintaining the game!",
            ["projects.featured.btn"] = "Play Store page",
            ["projects.p1.meta"] = "2024/2025 — Full-Stack",
            ["projects.p1.desc"] = "I was responsible for refactoring many combat preview mechanics. Far more than just simple calculations, troubleshooting bugs required me to work on the data, the client, and the server.",
            ["projects.p2.meta"] = "2023 — Frontend",
            ["projects.p2.desc"] = "I developed the technical aspects of the game's new interfaces, taking into account new specifications and features. Working directly with the UI/UX lead, I handled everything from prototyping mockups to user testing.",
            ["projects.p3.meta"] = "2020/2021 — Data",
            ["projects.p3.desc"] = "I designed and implemented KPIs and monitoring dashboards for the Decathlon production platform, with a strong focus on performance and reliability metrics.",
            ["projects.p4.meta"] = "2021 — Product Owner",
            ["projects.p4.desc"] = "As part of learning agile methodology, I took on the role of product owner on a project I led with fellow students. I defined the application's requirements, task priorities, and user stories.",
            ["projects.p5.meta"] = "2021 — Solo dev",
            ["projects.p5.desc"] = "Started as a student project, I finalised and released it on the Play Store. It lets Magic: The Gathering players search for cards with specific filters, save them for easy retrieval, and monitor their price fluctuations.",
            ["projects.p6.meta"] = "2021 — Full-Stack",
            ["projects.p6.desc"] = "A multiplayer VR meeting application where users can project documents, interact with objects, and collaborate in real time across the network.",
            ["projects.p7.meta"] = "2026 — Full-Stack",
            ["projects.p7.desc"] = "This very portfolio — built with Blazor WebAssembly and deployed on GitHub Pages. Neobrutalist design, bilingual (EN/FR), zero dependencies.",

            // ABOUT
            ["about.hero.title"] = "About Me",
            ["about.hero.subtitle"] = "Beyond the code — who I am, what drives me, and how I spend my time away from the keyboard.",
            ["about.whoiam.title"] = "Who I Am",
            ["about.bio1"] = "I was born and raised in a small village in northern France. From a very young age, I was immersed in the world of video games, and this gradually nurtured my passion for computer science. I quickly wanted to work in the video game industry, and I'm very proud to already be able to say that I've done it!",
            ["about.bio2"] = "Even though I play video games much less these days, I still have a passion for tech and I still love solving problems! If you can't find me behind a screen, look for me on the trails or at the gym!",
            ["about.facts.title"] = "Quick Facts",
            ["about.facts.location"] = "Location",
            ["about.facts.age"] = "Age",
            ["about.facts.languages"] = "Languages",
            ["about.facts.languages.value"] = "French (Native), English (C1)",
            ["about.facts.status"] = "Status",
            ["about.facts.availability.label"] = "Availability",
            ["about.facts.availability.value"] = "Immediate",
            ["about.facts.opentowork"] = "Open to Work",
            ["about.hobbies.title"] = "Hobbies & Interests",
            ["about.hobby.gaming.title"] = "Gaming",
            ["about.hobby.gaming.desc"] = "As I said, I still play video games from time to time! Well equipped, I try a bit of everything, but God of War and Zelda remain my favourite.",
            ["about.hobby.reading.title"] = "Reading",
            ["about.hobby.reading.desc"] = "I have a well-stocked library, mainly filled with science fiction, fantasy, and comic books. Unfortunately, the books tend to pile up faster than I can read them... whoops!",
            ["about.hobby.workout.title"] = "Working out",
            ["about.hobby.workout.desc"] = "\"Mens sana in corpore sano\" — A healthy mind in a healthy body. There's nothing like giving it your all at the gym to unwind!",
            ["about.hobby.travel.title"] = "Travelling",
            ["about.hobby.travel.desc"] = "Discovering new things is incredibly enriching, and to do that, all you have to do is step outside your home!",
            ["about.values.title"] = "What I Value (at work)",
            ["about.value1.title"] = "Continuous Learning",
            ["about.value1.desc"] = "Stagnation is something that scares me; I always want to learn, whether through my successes or my failures — I always want to improve.",
            ["about.value2.title"] = "Clean code...",
            ["about.value2.desc"] = "A well-thought-out, elegant solution that benefits everyone, both for development and maintenance.",
            ["about.value3.title"] = "...that works!",
            ["about.value3.desc"] = "But it has to work! Far too often, we forget that the most important thing in software engineering is that it works!",

            // CONTACT
            ["contact.hero.title"] = "Get In Touch",
            ["contact.hero.subtitle"] = "Whether you have a project in mind, a question, or just want to say hi — my inbox is always open.",
            ["contact.info.title"] = "Contact Info",
            ["contact.info.email.label"] = "Email",
            ["contact.info.location.label"] = "Location",
            ["contact.info.linkedin.label"] = "LinkedIn",
            ["contact.info.github.label"] = "GitHub",
            ["contact.availability.title"] = "Availability",
            ["contact.availability.text"] = "Currently <span style=\"color: var(--teal); font-weight: 700;\">available</span> for full-time positions and consulting opportunities.",
            ["contact.availability.response"] = "Typical response time: 24 hours.",
            ["contact.btn.go"] = "Go!",

            // NOT FOUND
            ["notfound.subtitle"] = "Oops — this page doesn't exist.",
            ["notfound.btn"] = "← Back Home",
        },

        [LanguageService.Language.FR] = new()
        {
            // NAV
            ["nav.home"] = "Accueil",
            ["nav.projects"] = "Projets",
            ["nav.about"] = "À propos",
            ["nav.contact"] = "Contact",

            // FOOTER
            ["footer.text"] = "Fait par moi ! ヾ(⌐■_■)ノ",

            // HOME — INTRO
            ["home.role"] = "Ingénieur Logiciel",
            ["home.intro"] = "Bonjour, je suis Sébastien, un ingénieur logiciel de 26 ans basé en France, titulaire d'un master en Informatique spécialisé dans le développement et la gestion de logiciels. Curieux, créatif, passionné par la technologie et le management agile, avec un goût pour l'aventure et la découverte — je suis toujours en quête de nouveaux défis et d'opportunités de progression.",
            ["home.btn.projects"] = "Voir les projets",
            ["home.btn.contact"] = "Me contacter",
            ["home.marquee"] = "✦ DÉVELOPPEUR &nbsp;&nbsp;&nbsp; ✦ RÉSOLVEUR DE PROBLÈMES &nbsp;&nbsp;&nbsp; ✦ OUVERT AUX OPPORTUNITÉS &nbsp;&nbsp;&nbsp; ✦ INGÉNIEUR LOGICIEL &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;",

            // HOME — STATS
            ["home.stats.experience"] = "Ans d'expérience",
            ["home.stats.thousands"] = "MILLIERS",
            ["home.stats.tickets"] = "de Tickets résolus",
            ["home.stats.tech"] = "Technologies maîtrisées",
            ["home.stats.toeic"] = "SCORE TOEIC",

            // HOME — EDUCATION
            ["home.education.title"] = "Formation",
            ["home.edu.master.title"] = "Master en Informatique",
            ["home.edu.master.school"] = "Université de Lille",
            ["home.edu.master.desc"] = "Spécialisation en Génie Logiciel. Diplômé avec mention bien. Mémoire de master sur la consommation énergétique du développement et de l'utilisation des solutions informatiques.",
            ["home.edu.master.tag1"] = "Diplômé avec mention bien",
            ["home.edu.master.tag2"] = "Génie Logiciel",
            ["home.edu.master.tag3"] = "Gestion de projet",
            ["home.edu.bachelor.title"] = "Licence en Informatique",
            ["home.edu.bachelor.school"] = "Université de Lille",
            ["home.edu.bachelor.desc"] = "Première année entièrement effectuée en anglais. Aperçu général de l'informatique.",
            ["home.edu.bachelor.tag1"] = "Dév. Web",
            ["home.edu.bachelor.tag2"] = "Réseaux",
            ["home.edu.bachelor.tag3"] = "Programmation Système",
            ["home.edu.bachelor.tag4"] = "Programmation Objet",
            ["home.edu.highschool.title"] = "Baccalauréat",
            ["home.edu.highschool.school"] = "Lycée des Flandres",
            ["home.edu.highschool.desc"] = "Baccalauréat avec spécialité Sciences (BAC S).",
            ["home.edu.highschool.tag1"] = "Diplômé avec mention très bien",

            // HOME — EXPERIENCE
            ["home.experience.title"] = "Expérience Professionnelle",
            ["home.exp1.title"] = "Développeur C# (.NET) / Java",
            ["home.exp1.period"] = "Novembre 2022 – Août 2025",
            ["home.exp1.desc"] = "J'ai rejoint Ankama dans le cadre du portage technique du jeu vidéo Dofus de la technologie Flash vers le moteur de jeu Unity. Au sein d'une équipe de 10 développeurs front-end, j'ai développé de nouvelles fonctionnalités, corrigé des bugs et optimisé les performances du jeu. J'ai également été en charge du développement des nouvelles interfaces et assuré la qualité du code à travers de nombreuses revues de code.",
            ["home.exp2.title"] = "Ingénieur Support",
            ["home.exp2.period"] = "Septembre 2021 – Septembre 2022",
            ["home.exp2.desc"] = "Intégré au cœur de la chaîne d'approvisionnement, j'ai mis en place la supervision des bases de données et des applications utilisées par les pays de production. J'ai configuré des visualisations de nombreux KPIs selon les besoins des équipes et facilité certaines cérémonies agiles. J'ai également contribué au groupe \"Sustainable Value Chain for Industry\" pour mettre en place un système de monitoring de la consommation de nos logiciels.",
            ["home.exp3.title"] = "Développeur C#",
            ["home.exp3.period"] = "Avril 2021 – Août 2021",
            ["home.exp3.desc"] = "J'ai rejoint l'INRIA pour soutenir le développement technique de la thèse d'un doctorant axée sur les \"Techniques d'Interaction pour la Sélection d'Objets et le Contrôle des Expressions Faciales en Réalité Virtuelle\", encadrée par deux professeurs. Mon rôle était de gamifier l'expérience et de mettre en place une scène de réunion VR où les utilisateurs pouvaient projeter des documents, interagir avec des objets et collaborer sur le réseau.",

            // HOME — SKILLS
            ["home.skills.title"] = "Compétences",
            ["home.skills.technical"] = "Compétences Techniques",
            ["home.skills.tools"] = "Outils & Soft Skills",
            ["home.skill.agile"] = "Méthode Agile",
            ["home.skill.git"] = "Git",
            ["home.skill.cicd"] = "CI/CD Pipelines",
            ["home.skill.tracking"] = "Jira / Youtrack",
            ["home.skill.cloud"] = "Plateformes Cloud",
            ["home.skill.architecture"] = "Architecture Logicielle",
            ["home.skill.api"] = "APIs REST / SOAP",
            ["home.skill.uiux"] = "UI / UX",
            ["home.skill.documentation"] = "Documentation Technique",
            ["home.skill.codereview"] = "Revue de code",
            ["home.skill.communication"] = "Communication & Empathie",

            // PROJECTS
            ["projects.hero.title"] = "Mes Projets",
            ["projects.hero.subtitle"] = "Une sélection de projets personnels et professionnels.",
            ["projects.featured.label"] = "Projet Phare",
            ["projects.all.label"] = "Tous les Projets",
            ["projects.featured.meta"] = "2020 — Jeu vidéo",
            ["projects.featured.desc1"] = "Mon favori personnel, mon jeu, 100% fait maison ! Du gameplay au son, en passant par les interfaces et bien sûr la programmation. C'est mon premier grand projet personnel — un vrai défi que je me suis fixé pendant le confinement COVID-19. J'avais enfin accès à du matériel capable de faire tourner Unity, et surtout beaucoup de temps à mettre à profit.",
            ["projects.featured.desc2"] = "Il m'a permis d'améliorer mes compétences en développement et de comprendre le cycle de vie du développement logiciel. Même en travaillant seul, j'ai eu un avant-goût de la définition des spécifications, de la conception, du déploiement et de la maintenance d'un jeu !",
            ["projects.featured.btn"] = "Page Play Store",
            ["projects.p1.meta"] = "2024/2025 — Full-Stack",
            ["projects.p1.desc"] = "J'ai été en charge du refactoring de nombreuses mécaniques de prévisualisation des combats. Bien plus que de simples calculs, la résolution de bugs m'a demandé de travailler sur les données, le client et le serveur.",
            ["projects.p2.meta"] = "2023 — Frontend",
            ["projects.p2.desc"] = "J'ai développé les aspects techniques des nouvelles interfaces du jeu, en tenant compte des nouvelles spécifications et fonctionnalités. Travaillant directement avec le responsable UI/UX, j'ai géré tout le processus, des maquettes aux tests utilisateurs.",
            ["projects.p3.meta"] = "2020/2021 — Données",
            ["projects.p3.desc"] = "J'ai conçu et mis en place des KPIs et des tableaux de bord de monitoring pour la plateforme de production Decathlon, avec un fort accent sur les métriques de performance et de fiabilité.",
            ["projects.p4.meta"] = "2021 — Chef de Produit",
            ["projects.p4.desc"] = "Dans le cadre de l'apprentissage de la méthode agile, j'ai endossé le rôle de Product Owner sur un projet mené avec mes camarades. J'ai défini les exigences de l'application, les priorités des tâches et les user stories.",
            ["projects.p5.meta"] = "2021 — Dév. solo",
            ["projects.p5.desc"] = "Commencé comme projet étudiant, j'ai finalisé l'application et l'ai publiée sur le Play Store. Elle permet aux joueurs de Magic: The Gathering de rechercher des cartes avec des filtres spécifiques et de suivre leurs fluctuations de prix.",
            ["projects.p6.meta"] = "2021 — Full-Stack",
            ["projects.p6.desc"] = "Une application de réunion VR multijoueur où les utilisateurs peuvent projeter des documents, interagir avec des objets et collaborer en temps réel sur le réseau.",
            ["projects.p7.meta"] = "2026 — Full-Stack",
            ["projects.p7.desc"] = "Ce portfolio — développé en Blazor WebAssembly et déployé sur GitHub Pages. Design néobrutalist, bilingue (FR/EN), zéro dépendance.",

            // ABOUT
            ["about.hero.title"] = "À Propos",
            ["about.hero.subtitle"] = "Au-delà du code — qui je suis, ce qui me motive et comment je passe mon temps loin du clavier.",
            ["about.whoiam.title"] = "Qui Suis-Je",
            ["about.bio1"] = "Né et élevé dans un petit village du nord de la France, j'ai été très tôt plongé dans l'univers du jeu vidéo, ce qui a progressivement nourri ma passion pour l'informatique. J'ai rapidement voulu travailler dans l'industrie du jeu vidéo, et je suis très fier de pouvoir déjà dire que je l'ai fait !",
            ["about.bio2"] = "Même si je joue beaucoup moins aux jeux vidéo aujourd'hui, j'ai toujours une passion pour la technologie et j'adore résoudre des problèmes ! Si vous ne me trouvez pas devant un écran, cherchez-moi sur les sentiers ou à la salle de sport !",
            ["about.facts.title"] = "En bref",
            ["about.facts.location"] = "Localisation",
            ["about.facts.age"] = "Âge",
            ["about.facts.languages"] = "Langues",
            ["about.facts.languages.value"] = "Français (Natif), Anglais (C1)",
            ["about.facts.status"] = "Statut",
            ["about.facts.availability.label"] = "Disponibilité",
            ["about.facts.availability.value"] = "Immédiate",
            ["about.facts.opentowork"] = "En recherche d'emploi",
            ["about.hobbies.title"] = "Loisirs & Intérêts",
            ["about.hobby.gaming.title"] = "Jeux Vidéo",
            ["about.hobby.gaming.desc"] = "Comme je l'ai dit, je joue encore aux jeux vidéo de temps en temps ! Bien équipé, j'essaie un peu de tout, mais God of War et Zelda restent mes préférés.",
            ["about.hobby.reading.title"] = "Lecture",
            ["about.hobby.reading.desc"] = "J'ai une bibliothèque bien fournie, principalement remplie de science-fiction, de fantasy et de bandes dessinées. Malheureusement, les livres s'accumulent plus vite que je ne peux les lire... oups !",
            ["about.hobby.workout.title"] = "Sport",
            ["about.hobby.workout.desc"] = "\"Mens sana in corpore sano\" — Un esprit sain dans un corps sain. Rien de tel que de se dépasser à la salle de sport pour décompresser !",
            ["about.hobby.travel.title"] = "Voyager",
            ["about.hobby.travel.desc"] = "Découvrir de nouvelles choses est incroyablement enrichissant, et pour cela, il suffit de sortir de chez soi !",
            ["about.values.title"] = "Ce Que Je Valorise (au travail)",
            ["about.value1.title"] = "Apprentissage Continu",
            ["about.value1.desc"] = "La stagnation me fait peur ; je veux toujours apprendre, que ce soit à travers mes succès ou mes échecs — je veux toujours m'améliorer.",
            ["about.value2.title"] = "Du code propre...",
            ["about.value2.desc"] = "Une solution bien pensée et élégante qui profite à tous, tant pour le développement que pour la maintenance.",
            ["about.value3.title"] = "...qui fonctionne !",
            ["about.value3.desc"] = "Mais ça doit fonctionner ! Bien trop souvent, on oublie que le plus important en génie logiciel, c'est que ça marche !",

            // CONTACT
            ["contact.hero.title"] = "Me Contacter",
            ["contact.hero.subtitle"] = "Que vous ayez un projet en tête, une question, ou que vous vouliez simplement dire bonjour — ma boîte mail est toujours ouverte.",
            ["contact.info.title"] = "Mes Coordonnées",
            ["contact.info.email.label"] = "Email",
            ["contact.info.location.label"] = "Localisation",
            ["contact.info.linkedin.label"] = "LinkedIn",
            ["contact.info.github.label"] = "GitHub",
            ["contact.availability.title"] = "Disponibilité",
            ["contact.availability.text"] = "Actuellement <span style=\"color: var(--teal); font-weight: 700;\">disponible</span> pour des postes à temps plein et des opportunités de consulting.",
            ["contact.availability.response"] = "Délai de réponse habituel : 24 heures.",
            ["contact.btn.go"] = "Visiter !",

            // NOT FOUND
            ["notfound.subtitle"] = "Oups — cette page n'existe pas.",
            ["notfound.btn"] = "← Retour à l'Accueil",
        }
    };

    public static string Get(string key, LanguageService.Language lang)
    {
        if (_data.TryGetValue(lang, out var dict) && dict.TryGetValue(key, out var val))
            return val;
        if (_data.TryGetValue(LanguageService.Language.EN, out var en) && en.TryGetValue(key, out var fallback))
            return fallback;
        return key;
    }
}

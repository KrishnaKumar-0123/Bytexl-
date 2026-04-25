:root {
  --bg: #fdfaf4;
  --text: #14213d;
  --accent: #ff7b00;
  --accent-2: #0f9d58;
  --deep: #0b132b;
  --muted: #596275;
  --card: #ffffff;
  --shadow: 0 12px 28px rgba(20, 33, 61, 0.14);
}

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

html {
  scroll-behavior: smooth;
}

body {
  font-family: "Manrope", sans-serif;
  color: var(--text);
  background: radial-gradient(circle at top left, #fff3d9 0%, #f9f9f9 45%, #e7f4f0 100%);
  line-height: 1.6;
}

.hero {
  min-height: 95vh;
  background:
    linear-gradient(110deg, rgba(11, 19, 43, 0.75), rgba(15, 157, 88, 0.4)),
    url("https://images.unsplash.com/photo-1548013146-72479768bada?auto=format&fit=crop&w=1800&q=80") center/cover no-repeat;
  color: #fff;
  position: relative;
  padding: 1.5rem 6vw 4rem;
}

.nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 1rem;
}

.brand {
  font-family: "Playfair Display", serif;
  font-size: 1.3rem;
  font-weight: 700;
  letter-spacing: 0.2px;
}

.nav-links {
  list-style: none;
  display: flex;
  gap: 1.5rem;
}

.nav-links a {
  color: #fff;
  text-decoration: none;
  font-weight: 600;
  border-bottom: 2px solid transparent;
  transition: border-color 0.3s;
}

.nav-links a:hover {
  border-color: #ffd166;
}

.menu-toggle {
  display: none;
  border: none;
  background: rgba(255, 255, 255, 0.2);
  color: #fff;
  font-size: 1.1rem;
  padding: 0.35rem 0.65rem;
  border-radius: 6px;
  cursor: pointer;
}

.hero-content {
  max-width: 700px;
  margin-top: 11vh;
  animation: fadeUp 0.9s ease;
}

.tagline {
  text-transform: uppercase;
  letter-spacing: 2px;
  font-size: 0.78rem;
  opacity: 0.95;
  margin-bottom: 0.8rem;
}

h1 {
  font-family: "Playfair Display", serif;
  font-size: clamp(2.1rem, 5vw, 4rem);
  line-height: 1.1;
}

.sub {
  margin: 1.2rem 0 1.8rem;
  font-size: 1.05rem;
  max-width: 60ch;
}

.cta {
  display: inline-block;
  padding: 0.85rem 1.5rem;
  background: linear-gradient(90deg, var(--accent), #ffb703);
  color: #171717;
  text-decoration: none;
  font-weight: 700;
  border-radius: 8px;
  box-shadow: var(--shadow);
  transition: transform 0.25s;
}

.cta:hover {
  transform: translateY(-2px);
}

.section {
  padding: 4.5rem 6vw;
}

.section-head {
  margin-bottom: 1.8rem;
}

.eyebrow {
  text-transform: uppercase;
  letter-spacing: 2px;
  font-size: 0.75rem;
  color: var(--accent-2);
  font-weight: 700;
}

h2 {
  font-family: "Playfair Display", serif;
  font-size: clamp(1.7rem, 3vw, 2.5rem);
  color: var(--deep);
}

.filters {
  display: flex;
  flex-wrap: wrap;
  gap: 0.6rem;
  margin-bottom: 1.3rem;
}

.filter-btn {
  border: 1px solid #d9dfeb;
  background: #fff;
  color: var(--text);
  padding: 0.45rem 0.85rem;
  border-radius: 999px;
  cursor: pointer;
  font-weight: 600;
}

.filter-btn.active,
.filter-btn:hover {
  background: var(--deep);
  color: #fff;
  border-color: var(--deep);
}

.card-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(230px, 1fr));
  gap: 1rem;
}

.card {
  background: var(--card);
  border-radius: 8px;
  overflow: hidden;
  box-shadow: var(--shadow);
  transform: translateY(0);
  transition: transform 0.3s, box-shadow 0.3s;
}

.card.hidden {
  display: none;
}

.card img {
  width: 100%;
  height: 190px;
  object-fit: cover;
}

.card-content {
  padding: 1rem;
}

.card h3 {
  margin-bottom: 0.4rem;
  font-size: 1.1rem;
}

.card p {
  color: var(--muted);
  font-size: 0.95rem;
}

.card:hover {
  transform: translateY(-4px);
  box-shadow: 0 16px 30px rgba(20, 33, 61, 0.2);
}

.experiences {
  background: linear-gradient(180deg, #fff 0%, #f4f8ff 100%);
}

.experience-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
  gap: 1rem;
}

.experience-card {
  background: #fff;
  border-left: 4px solid var(--accent);
  padding: 1.1rem;
  border-radius: 8px;
  box-shadow: var(--shadow);
}

.stats {
  position: relative;
  color: #fff;
  background: url("https://images.unsplash.com/photo-1524492412937-b28074a5d7da?auto=format&fit=crop&w=1800&q=80") center/cover fixed;
}

.stats .overlay {
  position: absolute;
  inset: 0;
  background: rgba(11, 19, 43, 0.72);
}

.stats-content {
  position: relative;
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(180px, 1fr));
  gap: 1.2rem;
}

.stat {
  text-align: center;
  background: rgba(255, 255, 255, 0.08);
  border: 1px solid rgba(255, 255, 255, 0.2);
  border-radius: 8px;
  padding: 1.3rem 1rem;
}

.count {
  font-family: "Playfair Display", serif;
  font-size: 2.3rem;
  font-weight: 700;
  color: #ffd166;
}

.plan {
  background: linear-gradient(135deg, #fff4e0 0%, #e5f3ed 100%);
}

.trip-form {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(210px, 1fr));
  gap: 0.8rem;
}

.trip-form input,
.trip-form select {
  width: 100%;
  border: 1px solid #c7d0df;
  border-radius: 8px;
  padding: 0.8rem 0.7rem;
  font-family: inherit;
  font-size: 0.95rem;
}

.trip-form button {
  border: none;
  border-radius: 8px;
  background: linear-gradient(90deg, #ff7b00, #ffb703);
  color: #111;
  font-weight: 700;
  cursor: pointer;
  padding: 0.8rem 1rem;
}

.form-note {
  margin-top: 0.8rem;
  font-weight: 600;
  color: #115d38;
  min-height: 1.4rem;
}

.footer {
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 1rem;
  flex-wrap: wrap;
  padding: 1.4rem 6vw 1.6rem;
  background: var(--deep);
  color: #fff;
}

.footer a {
  color: #ffd166;
  text-decoration: none;
}

@keyframes fadeUp {
  from {
    opacity: 0;
    transform: translateY(22px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

@media (max-width: 860px) {
  .menu-toggle {
    display: inline-block;
  }

  .nav-links {
    display: none;
    position: absolute;
    right: 6vw;
    top: 68px;
    flex-direction: column;
    padding: 0.9rem;
    border-radius: 8px;
    background: rgba(11, 19, 43, 0.95);
    box-shadow: var(--shadow);
    width: min(220px, 84vw);
  }

  .nav-links.open {
    display: flex;
  }

  .hero-content {
    margin-top: 9vh;
  }
}


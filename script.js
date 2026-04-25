const filterButtons = document.querySelectorAll(".filter-btn");
const cards = document.querySelectorAll(".card");
const menuToggle = document.getElementById("menuToggle");
const navLinks = document.getElementById("navLinks");
const form = document.querySelector(".trip-form");
const formNote = document.getElementById("formNote");

filterButtons.forEach((button) => {
  button.addEventListener("click", () => {
    filterButtons.forEach((btn) => btn.classList.remove("active"));
    button.classList.add("active");

    const type = button.dataset.filter;
    cards.forEach((card) => {
      const show = type === "all" || card.dataset.type === type;
      card.classList.toggle("hidden", !show);
    });
  });
});

menuToggle.addEventListener("click", () => {
  navLinks.classList.toggle("open");
});

document.querySelectorAll(".nav-links a").forEach((link) => {
  link.addEventListener("click", () => navLinks.classList.remove("open"));
});

// Trigger stat counters when stats section appears.
const counterElements = document.querySelectorAll(".count");
const speed = 40;
let hasAnimated = false;

const animateCounters = () => {
  counterElements.forEach((counter) => {
    const target = Number(counter.dataset.target);
    const increment = Math.max(1, Math.floor(target / speed));
    let current = 0;

    const update = () => {
      current += increment;
      if (current >= target) {
        counter.textContent = target.toLocaleString();
        return;
      }
      counter.textContent = current.toLocaleString();
      requestAnimationFrame(update);
    };

    update();
  });
};

const observer = new IntersectionObserver(
  (entries) => {
    entries.forEach((entry) => {
      if (entry.isIntersecting && !hasAnimated) {
        hasAnimated = true;
        animateCounters();
      }
    });
  },
  { threshold: 0.4 }
);

const statsSection = document.getElementById("stats");
if (statsSection) observer.observe(statsSection);

form.addEventListener("submit", (event) => {
  event.preventDefault();
  formNote.textContent = "Thank you! Your itinerary request is received. We will contact you soon.";
  form.reset();
});


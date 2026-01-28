export function init(root, opts) {
    // Log for debugging purpose
    console.log("🔥 landing-fx init STARTED", root, opts);

    if (!root) {
        // Log for debugging purpose
        console.warn("landing-fx: root element is null");
        return;
    }

    // ----- options for radius of revealed content between layers of landing page-----
    const r2 = opts?.r2 ?? 320; // L1 -> L2
    const r3 = opts?.r3 ?? 200; // L2 -> L3
    const r4 = opts?.r4 ?? 110; // L3 -> L4
    const ease = opts?.ease ?? 0.12;

    // set CSS variables once
    root.style.setProperty("--r2", `${r2}px`);
    root.style.setProperty("--r3", `${r3}px`);
    root.style.setProperty("--r4", `${r4}px`);

    // ----- mouse state -----
    let targetX = 0.5;
    let targetY = 0.5;
    let currentX = 0.5;
    let currentY = 0.5;

    let dx = 0;
    let dy = 0;

    function onMouseMove(e) {
        const rect = root.getBoundingClientRect();
        if (!rect.width || !rect.height) return;

        targetX = (e.clientX - rect.left) / rect.width;
        targetY = (e.clientY - rect.top) / rect.height;

        // clamp
        targetX = Math.max(0, Math.min(1, targetX));
        targetY = Math.max(0, Math.min(1, targetY));
    }

    function onMouseLeave() {
        targetX = 0.5;
        targetY = 0.5;
    }

    root.addEventListener("mousemove", onMouseMove);
    root.addEventListener("mouseleave", onMouseLeave);

    // ----- animation loop -----
    function tick() {
        currentX += (targetX - currentX) * ease;
        currentY += (targetY - currentY) * ease;

        // spotlight position
        root.style.setProperty("--mx", `${currentX * 100}%`);
        root.style.setProperty("--my", `${currentY * 100}%`);

        // subtle parallax offsets
        dx = (currentX - 0.5) * 22;
        dy = (currentY - 0.5) * 22;

        root.style.setProperty("--dx", `${dx}px`);
        root.style.setProperty("--dy", `${dy}px`);

        requestAnimationFrame(tick);
    }

    requestAnimationFrame(tick);

    // Log for debugging purpose
    console.log("✅ landing-fx init COMPLETE");
}